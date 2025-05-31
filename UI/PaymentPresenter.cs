using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class PaymentPresenter : IPaymentPresenter
    {
        public IPayment view;
        public ClientFacade facade;
        private int priority = 1; // 1 - bonus, 2 - card, 3 - cash

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
            int numericsum = view.numericValues().Sum();
            int dif = totalsum - numericsum;

            view.setSumLeft("0");

            if (dif >= 0)
            {
                view.setSumLeft(dif.ToString());
                return dif;
            }

            int availableBonus = facade.GetBonus();
            int availableCard = facade.GetCardMoney();
            int availableCash = facade.GetCash();
            int remaining = -dif; 

 
            if (priority == 1) 
            {
                view.setCardSum(0);
                view.setCashSum(0);
            }
            else if (priority == 2) 
            {
                view.setBonusSum(0);
                view.setCashSum(0);
            }
            else if (priority == 3)
            {
                view.setBonusSum(0);
                view.setCardSum(0);
            }
            StreamWriter writer = new StreamWriter("file.txt", true);
            writer.WriteLine();
            if (priority == 1) 
            {
                writer.WriteLine($"priority 1, bonuses used {view.getBonusValue()}");
                int cardToUse = Math.Min(availableCard, remaining);
                view.setCardSum(cardToUse);
                remaining -= cardToUse;
                writer.WriteLine($"card {view.getCardValue()}");

                if (remaining > 0)
                {
                    int cashToUse = Math.Min(availableCash, remaining);
                    view.setCashSum(cashToUse);
                    remaining -= cashToUse;

                    writer.WriteLine($"cash {view.getCashValue()}");
                }
            }
            else if (priority == 2) 
            {
                writer.WriteLine($"priority 2, card used {view.getCardValue()}");
                int bonusToUse = Math.Min(availableBonus, remaining);
                view.setBonusSum(bonusToUse);
                remaining -= bonusToUse;
                writer.WriteLine($"bonus {view.getBonusValue()}");

                if (remaining > 0)
                {
                    int cashToUse = Math.Min(availableCash, remaining);
                    view.setCashSum(cashToUse);
                    remaining -= cashToUse;
                    writer.WriteLine($"cash {view.getCashValue()}");
                }
            }
            else if (priority == 3) 
            {
                writer.WriteLine($"priority 3, cash used {view.getCashValue()}");
                int bonusToUse = Math.Min(availableBonus, remaining);
                view.setBonusSum(bonusToUse);
                remaining -= bonusToUse;
                writer.WriteLine($"bonus {view.getBonusValue()}");

                if (remaining > 0)
                {
                    int cardToUse = Math.Min(availableCard, remaining);
                    view.setCardSum(cardToUse);
                    remaining -= cardToUse;
                    writer.WriteLine($"card {view.getCardValue()}");
                }
            }

            if (remaining > 0)
            {
                view.setSumLeft(remaining.ToString());
                return remaining;
            }

            return 0;
        }

        public void outLeftInfo()
        {
            calculateLeftSum();

            view.userInfoLeft_SetText($"Деньги на карте - {facade.GetCardMoney() - view.getCardValue()}\n" +
                $"Наличные - {facade.GetCash() - view.getCashValue()}\n" +
                $"Бонусы - {facade.GetBonus() - view.getBonusValue()}");
        }
    }
}