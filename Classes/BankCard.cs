namespace Classes
{
    public class BankCard
    {
        public int ID;

        public static int prevID = 0;
        public string Bank { get; set; }

        public readonly string Number;

        public readonly string CVC;

        public int Money { get; set; }

        public BankCard(string _bank)
        {
            ID = prevID++;
            prevID = ID;

            this.Bank = _bank;
            NumberGenerator(4, 4, out this.Number);
            NumberGenerator(1, 3, out this.CVC);
        }

        public BankCard(string _bank, string number, string cvc)
        {
            this.Bank = _bank;
            this.Number = number;
            this.CVC = cvc;
        }

        public void AddMoney(int value)
        {
            this.Money += value;
        }

        public void WithdrawMoney(int value)
        {
            if (value <= this.Money) this.Money -= value;
            else return;
        }

        public string AllInfo()
        {
            return $"{this.Bank}, {this.Number}, {this.CVC}";
        }

        public static string BankGenerator()
        {
            Random rand = new Random();
            List<string> list = ["T-bank", "Alfabank", "Sber", "Gazprombank", "VTB", "Bank Sankt-Peterburg"];
            return list[rand.Next(0, list.Count - 1)];
        }

        protected virtual void NumberGenerator(int parts, int lenth, out string s)
        {
            s = "";
            Random rand = new Random();

            for (int i = 0; i < parts; i++)
            {
                string stringMaxValue = "1";
                for (int j = 0; j < lenth; j++)
                {
                    stringMaxValue += "0";
                }

                int maxValue = Convert.ToInt32(stringMaxValue);

                string randNum = rand.Next(maxValue).ToString();
                LeftZeroFiller(ref randNum, lenth);

                s += randNum;
                if (i != parts - 1) s += " ";
            }
        }

        protected void LeftZeroFiller(ref string s, int rightEdge)
        {
            if (s.Length < rightEdge)
            {
                for (int j = s.Length; j < rightEdge; j++)
                {
                    s = "0" + s;
                }
            }
        }
    }
}
