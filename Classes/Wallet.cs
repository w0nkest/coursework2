namespace Classes
{
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

        public void addCash(int value) => Cash += value;

        public void withdrawCash(int value)
        {
            if (Cash >= value) Cash -= value;
            else return;
        }
    }
}
