using Classes;
using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Globalization;
using System.Security.Cryptography;

namespace UI
{
    internal class PaymentPresenter : IPaymentPresenter
    {
        public IPayment view;
        public ClientFacade facade;
        private int priority = 1; // 1 - bonus, 2 - card, 3 - cash
        private int bonuscarrier;
        private string bonuswritten;

        public PaymentPresenter(IPayment view, ClientFacade facade)
        {
            this.view = view;
            this.facade = facade;

            calculateSum();
            calculateLeftSum();

            view.userInfo_SetText($"Клиент - {facade.GetName()}\nКоличество бонусов - {facade.GetBonus()}" +
                $"\nВ кошельке - {facade.GetCash()} руб.\nНа карте - {facade.GetCardMoney()} руб.");
        }

        public void zeroingValues()
        {
            view.setBonusSum(0);
            view.setCardSum(0);
            view.setCashSum(0);
            calculateLeftSum();
        }

        public void cardPayment()
        {
            priority = 2;
            zeroingValues();

            if (facade.GetCardMoney() >= calculateSum())
            {
                view.setSumLeft("0");
                view.setCardSum(calculateSum());
            }
            else
            {
                view.setCardSum(facade.GetCardMoney());
                int left = calculateLeftSum();

                if (left == 0)
                    view.raiseMsgBox("Денег на карте не хватило, но доплата была совершена!");
                else
                    view.raiseMsgBox($"Денег на карте не хватило! Доплатите бонусами или наличными! К доплате {left}");
            }
        }

        public void cashPayment()
        {
            priority = 3;
            zeroingValues();

            if (facade.GetCash() >= calculateSum())
            {
                view.setSumLeft("0");
                view.setCashSum(calculateSum());
            }
            else
            {
                view.setCashSum(facade.GetCash());
                int left = calculateLeftSum();

                if (left == 0)
                    view.raiseMsgBox("Наличных не хватило, но доплата была совершена!");
                else
                    view.raiseMsgBox($"Наличных не хватило! Доплатите бонусами или картой! К доплате {left}");
            }
        }

        public void bonusPayment()
        {
            priority = 1;
            zeroingValues();

            if (facade.GetBonus() >= calculateSum())
            {
                view.setSumLeft("0");
                view.setBonusSum(calculateSum());
            }
            else
            {
                view.setBonusSum(facade.GetBonus());
                int left = calculateLeftSum();

                if (left == 0)
                    view.raiseMsgBox("Бонусов для оплаты недостаточно, но доплата была совершена!");
                else
                    view.raiseMsgBox($"Бонусов не хватает! Доплатите картой или наличными! К доплате {left}");
            }
        }

        public void closeTab(Form form)
        {
            form.Close();
        }

        public int calculateSum()
        {
            int sum = view.getCart().Sum(good => good.GetPrice());
            view.setSum(sum.ToString());
            return sum;
        }

        public int calculateLeftSum()
        {
            int totalsum = calculateSum();
            int cardValue = view.getCardValue();
            int cashValue = view.getCashValue();
            int bonusValue = view.getBonusValue();
            int currentSum = cardValue + cashValue + bonusValue;

            if (currentSum > totalsum)
            {
                if (priority == 1) 
                {

                    bonusValue = Math.Min(bonusValue, totalsum);
                    view.setBonusSum(bonusValue);

                    int remaining = totalsum - bonusValue;
                    cardValue = Math.Min(cardValue, remaining);
                    view.setCardSum(cardValue);

                    cashValue = Math.Min(cashValue, totalsum - bonusValue - cardValue);
                    view.setCashSum(cashValue);
                }
                else if (priority == 2)
                {
                    cardValue = Math.Min(cardValue, totalsum);
                    view.setCardSum(cardValue);

                    int remaining = totalsum - cardValue;
                    bonusValue = Math.Min(bonusValue, remaining);
                    view.setBonusSum(bonusValue);

                    cashValue = Math.Min(cashValue, totalsum - cardValue - bonusValue);
                    view.setCashSum(cashValue);
                }
                else if (priority == 3)
                {
                    cashValue = Math.Min(cashValue, totalsum);
                    view.setCashSum(cashValue);

                    int remaining = totalsum - cashValue;
                    bonusValue = Math.Min(bonusValue, remaining);
                    view.setBonusSum(bonusValue);

                    cardValue = Math.Min(cardValue, totalsum - cashValue - bonusValue);
                    view.setCardSum(cardValue);
                }
            }

            int leftToPay = totalsum - (view.getCardValue() + view.getCashValue() + view.getBonusValue());
            view.setSumLeft(Math.Max(0, leftToPay).ToString());

            return Math.Max(0, leftToPay);
        }

        public void outLeftInfo()
        {
            calculateLeftSum();

            view.userInfoLeft_SetText($"Деньги на карте - {facade.GetCardMoney() - view.getCardValue()}\n" +
                $"Наличные - {facade.GetCash() - view.getCashValue()}\n" +
                $"Бонусы - {facade.GetBonus() - view.getBonusValue()}");
        }

        public void paymentProcess(Form frm)
        {
            if (calculateLeftSum() > 0)
            {
                view.raiseMsgBox("Сумма не была набрана!");
                return;
            }

            facade.WithdrawCash(view.getCashValue());
            facade.WithdrawBonus(view.getBonusValue());
            facade.WithdrawCardMoney(view.getCardValue());

            int moneyForBonus = calculateSum() - view.getBonusValue();
            if (moneyForBonus > 0)
            {
                facade.AddBonus(DateTime.Now, moneyForBonus);
            }

            changeCard();
            changeCash();
            changeBonus();

            closeTab(frm);
        }

        private void changeCard()
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            int cardid = facade.IDs()["bID"];

            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = $"UPDATE bankcards SET money = {facade.GetCardMoney()} WHERE ID = {cardid}";
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
                connection.Close();
            }
        }

        private void changeCash()
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            int cid = facade.IDs()["cID"];

            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = $"UPDATE clients SET cash = {facade.GetCash()} WHERE ID = {cid}";
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                    }
                }
                connection.Close();
            }
        }

        private void changeBonus()
        {
            Batteries.Init();
            string pathdb = @"..\..\..\Resources\product_database.db";
            int cid = facade.IDs()["cID"];

            using (var connection = new SqliteConnection($"Data Source={pathdb}"))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = connection.CreateCommand())
                        {
                            command.CommandText = $"DELETE FROM bonus_transaction WHERE bonus = {cid}";
                            command.ExecuteNonQuery();
                        }

                        foreach (var entry in facade.GetWallet().Bonuses.AddingHistory)
                        {
                            using (var command = connection.CreateCommand())
                            {
                                command.CommandText = $"INSERT INTO bonus_transaction (bonus, value, datetime) " +
                                                    $"VALUES ({cid}, {entry.Value * 10}, '{entry.Key}')";
                                command.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
                connection.Close();
            }
        }
    }
}