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
