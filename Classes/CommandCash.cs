namespace Classes
{
    public sealed class CommandAddCash : ICommand
    {
        private Wallet wallet;
        private int value;
        private int previousvalue;

        public CommandAddCash(Wallet wallet, int value)
        {
            this.wallet = wallet;
            this.value = value;
            this.previousvalue = wallet.Cash;
        }


        public void Execute() => wallet.addCash(value);

        public void Undo() => wallet.Cash = previousvalue;
    }

    public sealed class CommandWithdrawCash : ICommand
    {
        private Wallet wallet;
        private int value;
        private int previousvalue;

        public CommandWithdrawCash(Wallet wallet, int value)
        {
            this.wallet = wallet;
            this.value = value;
            this.previousvalue = wallet.Cash;
        }


        public void Execute() => wallet.withdrawCash(value);

        public void Undo() => wallet.Cash = this.previousvalue;
    }
}
