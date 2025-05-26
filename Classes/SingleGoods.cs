using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class SingleGoods : Goods
    {
        public SingleGoods(string name, int price) : base(name, price) { }

        public override int GetPrice()
        {
            return this.Price;
        }
    }
}
