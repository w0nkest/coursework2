using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class GoodsDecorator : Goods
    {
        public Goods wrappedGoods;

        public GoodsDecorator(Goods goods) : base(goods.Name, goods.Price) { this.wrappedGoods = goods; }

        public abstract override int GetPrice();
    }
}
