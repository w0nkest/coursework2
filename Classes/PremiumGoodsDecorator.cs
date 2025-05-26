using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    namespace Classes
    {
        public class PremiumGoodsDecorator : GoodsDecorator
        {
            private readonly int increasePercent = 20;

            public PremiumGoodsDecorator(Goods goods) : base(goods) { }

            public override int GetPrice()
            {
                return wrappedGoods.GetPrice() * (100 + increasePercent) / 100;
            }
        }
    }
}
