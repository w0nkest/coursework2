using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UI
{
    internal class ClientPresenter : IClientPresenter
    {
        public IClient view;
        public ClientFacade facade;

        public ClientPresenter(IClient view, ClientFacade facade)
        {
            this.view = view;
            this.facade = facade;

            initializeGoods();

            view.setUserText($"Клиент - {facade.GetName()}\nКоличество бонусов - {facade.GetBonus()}" +
                $"\nВ кошельке - {facade.GetCash()} руб.\nНа карте - {facade.GetCardMoney()} руб.");
        }

        public void initializeGoods()
        {
            Goods goods = new SingleGoods("Дубовый веник", 100);

            productAdding(goods);

            Goods goods2 = new TimeGoods("Баня 500руб/час", 500);

            productAdding(goods2);
        }

        public void loadPaymentForm()
        {
            if (facade.GetCash() + facade.GetCardMoney() + facade.GetBonus() >= calculatePurchaceSum())
            {
                foreach (var goods in view.getCart())
                {
                    //Console.WriteLine(goods.GetType());
                    if (goods.GetType() == typeof(TimeGoods))
                    {
                        //Console.WriteLine("timegood here");
                        if ((goods as TimeGoods).Hours <= 0)
                        {
                            view.raiseMsgBox("Какие-то товары не были указаны по продолжительности! Перепроверьте список!");
                            return;
                        }
                    }
                }
                (new PaymentForm(calculatePurchaceSum(), facade, view.getCart())).ShowDialog();
                return;
            }
            else view.raiseMsgBox("Ваших денег не хватает! Удалите товары, чтобы их сумма не превышвала " +
                $"{facade.GetCash() + facade.GetCardMoney() + facade.GetBonus()}");
        }

        public void productAdding(Goods goods)
        {
            view.addToProductList(goods);
        }

        public void cartAdding(Goods goods, int amount = -1)
        {
            if (goods.GetType() == typeof(TimeGoods))
            {
                TimeGoods timegoods = (TimeGoods)goods;

                if (amount != -1) timegoods.Hours = amount;
                else timegoods.Hours = 0;

                if (!view.getCart().Contains(goods))
                    view.addToCart(timegoods);
            }
            else
            {
                int alreadyinlist = 0;
                foreach (var item in view.getCart())
                    if (item.Name == goods.Name)
                        alreadyinlist++;

                if (amount != -1)
                {
                    if (amount > alreadyinlist)
                        for (int i = 0; i < amount - alreadyinlist; i++)
                            view.addToCart(goods);

                    else if (amount < alreadyinlist)
                        for (int i = 0; i < alreadyinlist - amount; i++)
                            cartRemoving(goods);
                }
                else view.addToCart(goods);
            }
            calculatePurchaceSum();
        }

        public void cartRemoving(Goods goods)
        {
            view.removeFromCart(goods);
            calculatePurchaceSum();
        }

        public int calculatePurchaceSum()
        {
            int sum = 0;
            foreach (Goods good in view.getCart())
            {
                sum += good.GetPrice();
            }
            view.setSum(sum.ToString());
            return sum;
        }

        public int goodsCounter(Goods goods)
        {
            if (goods is not null)
                if (goods.GetType() == typeof(TimeGoods))
                    return (goods as TimeGoods).Hours;

            int counter = 0;

            foreach (Goods good in view.getCart())
                if (good == goods)
                    counter++;

            return counter;
        }
    }
}
