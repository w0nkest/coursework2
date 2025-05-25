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

        public void ExecuteCommand(ICommand command) => command.Execute();

        public void UndoCommand(ICommand command) => command.Undo();
    }
}
