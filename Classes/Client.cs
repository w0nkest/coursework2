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

        public int getBonuses() { return wallet.Bonuses.Amount; }

        public int getCardMoney() { return wallet.bankCard.Money; }

        public int getCashMoney() { return wallet.Cash; }

        public void ExecuteCommand(ICommand command) => command.Execute();

        public void UndoCommand(ICommand command) => command.Undo();
    }
}
