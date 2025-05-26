using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class RegularVisitorGoodsDecorator : GoodsDecorator
    {
        private readonly int discountPercent = 20;

        public RegularVisitorGoodsDecorator(Goods goods) : base(goods) { }

        public override int GetPrice()
        {
            return wrappedGoods.GetPrice() * (100 - discountPercent) / 100;
        }
    }
}
