using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IAdminProduct
    {
        void setInfoText(string msg);

        void setName(string msg);

        void setPrice(string msg);

        void productListAdd(Goods good);

        void productListRemove(Goods good);

        void raiseMsgBox(string msg);

        void productListUpdate(Goods oldgood, Goods newgood);
    }
}
