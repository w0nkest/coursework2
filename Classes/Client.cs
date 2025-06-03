namespace Classes
{
    public class Client
    {
        public int ID;

        public static int prevID = 0;

        public string Name { get; set; }

        public Wallet wallet { get; set; }

        public Client(string name)
        {
            this.Name = name;
            wallet = new Wallet();
        }

        public Client(string name, Wallet wallet)
        {
            ID = prevID++;
            prevID = ID;

            this.Name = name;
            this.wallet = wallet;
        }

        public int getBonuses() { return wallet.Bonuses.Amount; }

        public int getCardMoney() { return wallet.bankCard.Money; }

        public int getCashMoney() { return wallet.Cash; }

        public void ExecuteCommand(ICommand command) => command.Execute();

        public void UndoCommand(ICommand command) => command.Undo();

        public override string ToString()
        {
            return Name;
        }
    }
}
