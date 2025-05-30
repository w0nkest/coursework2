namespace Classes
{
    public class CommandAddCard : ICommand
    {
        private BankCard bankCard;
        private int value;
        private int previousvalue;

        public CommandAddCard(BankCard card, int value)
        {
            this.bankCard = card;
            this.value = value;
            this.previousvalue = card.Money;
        }
        

        public void Execute() => bankCard.AddMoney(value);

        public void Undo() => bankCard.Money = previousvalue;
    }

    public class CommandWithdrawCard : ICommand
    {
        private BankCard bankCard;
        private int value;
        private int previousvalue;

        public CommandWithdrawCard(BankCard card, int value)
        {
            this.bankCard = card;
            this.value = value;
            this.previousvalue = card.Money;
        }


        public void Execute() => bankCard.WithdrawMoney(value);

        public void Undo() => bankCard.Money = previousvalue;
    }
}
