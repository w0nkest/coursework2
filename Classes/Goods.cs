namespace Classes
{
    public abstract class Goods
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Goods(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public abstract int GetPrice();
    }
}
