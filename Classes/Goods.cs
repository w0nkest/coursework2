namespace Classes
{
    public abstract class Goods
    {
        public int ID;
        public static int prevID = 0;

        public string Name { get; set; }

        public int Price { get; set; }

        public Goods(string name, int price)
        {
            ID = prevID++;
            prevID = ID;
            this.Name = name;
            this.Price = price;
        }

        public abstract int GetPrice();

        public override string ToString()
        {
            return $"{this.Name}, {this.Price}";
        }
    }
}
