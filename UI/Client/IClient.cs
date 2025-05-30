using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

namespace UI
{
    internal interface IClient
    {
        void setUserText(string msg);

        void setSum(string value);

        void addToProductList(Goods goods);

        void addToCart(Goods goods);

        void removeFromCart(Goods goods);

        List<Goods> getCart();

        void raiseMsgBox(string msg);
    }
}
