using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class TimeGoods : Goods
    {
        public int Hours { get; set; }

        public int TotalPrice { get; set; }

        public TimeGoods(string name, int price, int hours) : base(name, price)
        {
            this.Hours = hours;
            this.TotalPrice = this.Hours * this.Price;
        }

        public override int GetPrice()
        {
            return this.TotalPrice;
        }
    }
}
