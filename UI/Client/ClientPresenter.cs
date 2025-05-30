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
        public Client client;

        public ClientPresenter(IClient view, Client client)
        {
            this.view = view;
            this.client = client;
            initializeGoods();
            view.setUserText($"Клиент - {client.Name}\nКоличество бонусов - {client.getBonuses()}" +
                $"\nВ кошельке - {client.getCashMoney()} руб.\nНа карте - {client.getCardMoney()} руб.");
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
            if (client.getCashMoney() + client.getCardMoney() + client.getBonuses() >= calculatePurchaceSum())
            {
                foreach (var goods in view.getCart())
                {
                    if (goods.GetType() == typeof(TimeGoods) && (goods as TimeGoods).Hours > 0)
                    {
                        (new PaymentForm()).ShowDialog();
                        return;
                    }
                    else 
                    {
                        view.raiseMsgBox("Какие-то товары не были указаны по продолжительности! Перепроверьте список!");
                        return;
                    }
                }
            }
            else view.raiseMsgBox("Ваших денег не хватает! Удалите товары, чтобы их сумма не превышвала " +
                $"{client.getBonuses() + client.getCardMoney() + client.getCashMoney()}");
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
