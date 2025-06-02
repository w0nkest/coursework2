using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal class AdminProductPresenter : IAdminProductPresenter
    {
        private IAdminProduct view;
        private List<Goods> goods;

        public AdminProductPresenter(IAdminProduct frm, List<Goods> goods)
        {
            this.goods = goods;
            view = frm;

            foreach (var good in goods)
            {
                view.productListAdd(good);
            }
        }

        public void setProductData(Goods good)
        {
            view.setName(good.Name);
            view.setPrice(good.Price.ToString());
        }

        public void updateProduct(Goods good, string newname, string newprice)
        {
            if (good is null)
            {
                view.raiseMsgBox("Товар не был выбран!");
                return;
            }
            if (newname.Length == 0 || newprice.Length == 0)
            {
                view.raiseMsgBox("Какое-то значение не было введено!");
                return;
            }

            Goods newgood;

            if (typeof(TimeGoods) == good.GetType())
            { 
                newgood = new TimeGoods(newname, Convert.ToInt32(newprice));
            }

            else
            {
                newgood = new SingleGoods(newname, Convert.ToInt32(newprice));
            }

            goods[goods.IndexOf(good)] = newgood;

            view.productListUpdate(good, newgood);
        }

        public void createProduct(string newname, string newprice, bool isTime)
        {
            if (newname.Length == 0 || newprice.Length == 0)
            {
                view.raiseMsgBox("Какое-то значение не было введено!");
                return;
            }
            if (isTime)
            {
                TimeGoods good = new TimeGoods(newname, Convert.ToInt32(newprice));
                view.productListAdd(good);
                goods.Add(good);
            }
            else
            {
                SingleGoods good = new SingleGoods(newname, Convert.ToInt32(newprice));
                view.productListAdd(good);
                goods.Add(good);
            }
        }

        public void removeProduct(Goods good)
        {
            if (good is null)
            {
                view.raiseMsgBox("Объект для удаления не выбран!");
                return;
            }
            view.productListRemove(good);
            goods.Remove(good);
        }
    }
}
