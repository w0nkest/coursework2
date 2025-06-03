namespace Classes
{
    public class CommandAddBonus : ICommand
    {
        private Bonus bonus;
        private int value;
        private DateTime date;
        private Dictionary<string, int> beforeCommand;
        private int previousvalue;

        public CommandAddBonus(Bonus bonus, DateTime date, int value)
        {
            this.bonus = bonus;
            this.value = value;
            this.previousvalue = bonus.Amount;
            this.beforeCommand = new Dictionary<string, int>(bonus.AddingHistory);
        }

        public void Execute() => bonus.AddBonuses(date, value);

        public void Undo()
        {
            bonus.Amount = previousvalue;
            bonus.AddingHistory = new Dictionary<string, int>(beforeCommand);
        }
    }

    public class CommandWithdrawBonus : ICommand
    {
        private Bonus bonus;
        private int value;
        private int previousvalue;
        private Dictionary<string, int> beforeCommand;

        public CommandWithdrawBonus(Bonus bonus, int value)
        {
            this.bonus = bonus;
            this.value = value;
            this.previousvalue = bonus.Amount;
            this.beforeCommand = new Dictionary<string, int>(bonus.AddingHistory);
        }

        public void Execute() => bonus.WithdrawBonuses(value);

        public void Undo()
        {
            bonus.AddingHistory = new Dictionary<string, int>(beforeCommand);
            bonus.Amount = previousvalue;
        }
    }
}
