namespace Classes
{
    public class Client
    {
        public string Name { get; set; }

        public Wallet wallet { get; set; }

        public Client(string name)
        {
            this.Name = name;
            wallet = new Wallet();
        }

        public Client(string name, Wallet wallet)
        {
            this.Name = name;
            this.wallet = wallet;
        }
    }

    public class Wallet
    {
        public BankCard bankCard { get; private set; }

        public int Cash { get; set; } = 0;

        public Bonus Bonuses { get; set; }
        
        public Wallet()         // No data - constructor for new one's
        {
            string bank = BankCard.BankGenerator();
            this.bankCard = new BankCard(bank);
            this.Bonuses = new Bonus();
        }

        public Wallet(BankCard bankCard, Bonus bonus)     // Everything is already existing
        {
            this.bankCard = bankCard;
            this.Bonuses = bonus;
        }
    }

    public class BankCard
    {

        public string Bank { get; set; }

        public readonly string Number;

        protected readonly string CVC;

        public int Money { get; set; }

        public BankCard(string _bank)
        {
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
            List<string> list = [ "T-bank", "Alfabank", "Sber", "Gazprombank", "VTB", "Bank Sankt-Peterburg" ];
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

    public class Bonus
    {
        public int Amount { get; set; } = 0;

        protected Dictionary<DateTime, int> AddingHistory = new Dictionary<DateTime, int>();

        public void AddBonuses(DateTime date, int moneySpend)
        {
            this.AddingHistory[date] = (int)(moneySpend * 0.1);
            this.Amount += (int)(moneySpend * 0.1);
        }

        public void WithdrawBonuses(int value)
        {
            if (Amount >= value)
            {
                foreach (var item in this.AddingHistory)
                {
                    if (item.Value > value)
                    {
                        this.AddingHistory[item.Key] -= value;
                        return;
                    }
                    else
                    {
                        value -= item.Value;
                        this.AddingHistory.Remove(item.Key);
                    }
                }
                Amount -= value;
            }
            else return;
        }

        public void ClearBonuses()
        {
            int period = 3;     // Time in days of bonuses existing

            foreach (var item in this.AddingHistory)
            {
                if (item.Key.AddDays(period) < DateTime.Now) this.AddingHistory.Remove(item.Key);
                else return;
            }
        }
    }
}
