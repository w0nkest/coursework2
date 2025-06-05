using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IAdminProductPresenter
    {
        public void setProductData(Goods good);

        public void updateProduct(Goods good, string newname, string newprice);

        public void createProduct(string newname, string newprice, bool isTime);

        public void removeProduct(Goods good);
    }
}
