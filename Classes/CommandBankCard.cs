namespace Classes
{
    public class CommandAddCard : ICommand
    {
        private BankCard bankCard;
        private int value;

        public CommandAddCard(BankCard card, int value)
        {
            this.bankCard = card;
            this.value = value;
        }
        

        public void Execute() => bankCard.AddMoney(value);

        public void Undo() => bankCard.WithdrawMoney(value);
    }

    public class CommandWithdrawCard : ICommand
    {
        private BankCard bankCard;
        private int value;

        public CommandWithdrawCard(BankCard card, int value)
        {
            this.bankCard = card;
            this.value = value;
        }


        public void Execute() => bankCard.WithdrawMoney(value);

        public void Undo() => bankCard.AddMoney(value);
    }
}
