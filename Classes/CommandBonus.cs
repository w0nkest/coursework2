namespace Classes
{
    public class CommandAddBonus : ICommand
    {
        private Bonus bonus;
        private int value;
        private DateTime date;

        public CommandAddBonus(Bonus bonus, DateTime date, int value)
        {
            this.bonus = bonus;
            this.value = value;
        }

        public void Execute() => bonus.AddBonuses(date, value);

        public void Undo()
        {
            if (bonus.AddingHistory.TryGetValue(date, out var addedAmount))
            {
                bonus.Amount -= addedAmount;
                bonus.AddingHistory.Remove(date);
            }
        }
    }

    public class CommandWithdrawBonus : ICommand
    {
        private Bonus bonus;
        private int value;
        private Dictionary<DateTime, int> beforeCommand;

        public CommandWithdrawBonus(Bonus bonus, int value)
        {
            this.bonus = bonus;
            this.value = value;
            this.beforeCommand = new Dictionary<DateTime, int>(bonus.AddingHistory);
        }

        public void Execute() => bonus.WithdrawBonuses(value);

        public void Undo()
        {
            bonus.AddingHistory = new Dictionary<DateTime, int>(beforeCommand);
            bonus.Amount -= value;
        }
    }
}
