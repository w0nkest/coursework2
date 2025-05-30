using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IClientPresenter
    {
        void initializeGoods();

        void cartRemoving(Goods goods);

        void cartAdding(Goods goods, int amount);

        int calculatePurchaceSum();

        void productAdding(Goods goods);

        void loadPaymentForm();

        int goodsCounter(Goods goods);
    }
}
