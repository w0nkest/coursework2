namespace Classes
{
    public class TimeGoods : Goods
    {
        public int Hours { get; set; } = 0;

        public TimeGoods(string name, int price) : base(name, price)
        {
            this.Price = price;
        }

        public override int GetPrice()
        {
            return this.Price * Hours;
        }
    }
}
