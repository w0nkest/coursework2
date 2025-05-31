using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class PaymentPresenter : IPaymentPresenter
    {
        public IPayment view;
        public ClientFacade facade;

        public PaymentPresenter(IPayment view, ClientFacade facade) 
        { 
            this.view = view; this.facade = facade;

            calculateSum();
            calculateLeftSum();

            view.userInfo_SetText($"Клиент - {facade.GetName()}\nКоличество бонусов - {facade.GetBonus()}" +
                $"\nВ кошельке - {facade.GetCash()} руб.\nНа карте - {facade.GetCardMoney()} руб.");
        }

        public void cardPayment()
        {
            if (facade.GetCardMoney() >= calculateSum())
            {
                view.setSumLeft("0");
                view.setCardSum(calculateSum());
            }
            else
            {
                view.setCardSum(facade.GetCardMoney());

                if (calculateLeftSum() == 0) view.raiseMsgBox("Денег на карте не хватило, но доплата была совершена!");

                else view.raiseMsgBox($"Денег на карте не хватило! Доплатите бонусами или наличными! К доплате {calculateLeftSum()}");
            }
        }

        public void cashPayment()
        {
            if (facade.GetCash() >= calculateSum())
            {
                view.setSumLeft("0");
                view.setCashSum(calculateSum());
            }
            else
            {
                view.setCashSum(facade.GetCash());
                if (calculateLeftSum() == 0) view.raiseMsgBox($"Наличных не хватило, но доплата была совершена!");
                else view.raiseMsgBox($"Наличных не хватило! Доплатите бонусами или картой! К доплате {calculateLeftSum()}");
            }
        }

        public void closeTab(Form form) { form.Close(); }

        public int calculateSum()
        {
            int sum = 0;
            foreach (Goods good in view.getCart())
            {
                sum += good.GetPrice();
            }
            view.setSum(sum.ToString());
            return sum;
        }

        public int calculateLeftSum()
        {
            int totalsum = calculateSum();
            int numericsum = view.numericValues().Sum();
            int sum = totalsum - numericsum;

            if (sum >= 0)
            {
                view.setSumLeft(sum.ToString());
                return sum;
            }

            if (numericsum - view.getBonusValue() < totalsum) 
            { 
                view.setBonusSum(Math.Max(0, view.getBonusValue() - (numericsum - totalsum))); 
                Console.WriteLine("bonus ch"); 
            }
            else
            {
                if (numericsum - view.getBonusValue() - view.getCardValue() < totalsum) 
                { 
                    view.setBonusSum(0); 
                    view.setCardSum(Math.Max(0, view.getCardValue() - (numericsum - totalsum))); 
                    Console.WriteLine("bonus 0 card ch"); 
                }
                else 
                { 
                    view.setBonusSum(0); 
                    view.setCardSum(0); 
                    view.setCashSum(Math.Max(0, view.getCashValue() - (numericsum - totalsum))); 
                    Console.WriteLine("bonus 0 card 0 cash ch"); }
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
