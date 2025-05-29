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

        public ClientPresenter(IClient view)
        {
            this.view = view;
            initializeGoods();
        }

        public void initializeGoods()
        {
            Goods goods = new SingleGoods("Дубовый веник", 100);

            productAdding(goods);

            Goods goods2 = new TimeGoods("Баня 500руб/час", 500);

            productAdding(goods2);
        }

        public void productAdding(Goods goods)
        {
            view.addToProductList(goods);
        }

        public void cartAdding(Goods goods, int amount = 1)
        {
            if (goods.GetType() == typeof(TimeGoods))
            {
                TimeGoods timegoods = (TimeGoods)goods;
                timegoods.Hours = amount;
                if (!view.getCart().Contains(goods))
                    view.addToCart(timegoods);
            }
            else
            {
                int alreadyinlist = 0;
                foreach (var item in view.getCart())
                    if (item.Name == goods.Name)
                        alreadyinlist++;

                if (amount > alreadyinlist)
                    for (int i = 0; i < amount - alreadyinlist; i++)
                        view.addToCart(goods);

                else if (amount < alreadyinlist)
                    for (int i = 0; i < alreadyinlist - amount; i++)
                        cartRemoving(goods);
            }
            calculatePurchaceSum();
        }

        public void cartRemoving(Goods goods)
        {
            view.removeFromCart(goods);
            calculatePurchaceSum();
        }

        public void calculatePurchaceSum()
        {
            int sum = 0;
            foreach (Goods good in view.getCart())
            {
                sum += good.GetPrice();
            }
            view.setSum(sum.ToString());
        }
    }
}
