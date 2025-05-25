namespace Classes
{
    public class Bonus
    {
        public int Amount { get; set; } = 0;

        internal Dictionary<DateTime, int> AddingHistory = new Dictionary<DateTime, int>();

        public void AddBonuses(DateTime date, int moneySpend)
        {
            this.AddingHistory[date] = (int)(moneySpend * 0.1);
            this.Amount += (int)(moneySpend * 0.1);
        }

        public void WithdrawBonuses(int value)
        {
            if (this.Amount >= value)
            {
                foreach (var item in this.AddingHistory)
                {
                    if (item.Value > value)
                    {
                        this.AddingHistory[item.Key] -= value;
                        break;
                    }
                    else
                    {
                        value -= item.Value;
                        this.AddingHistory.Remove(item.Key);
                    }
                }
                this.Amount -= value;
            }
            else return;
        }

        public void ClearBonuses()
        {
            int period = 3;     // Time in days of bonuses existing

            foreach (var item in this.AddingHistory)
            {
                if (item.Key.AddDays(period) < DateTime.Now)
                {
                    Amount -= item.Value;
                    this.AddingHistory.Remove(item.Key);
                }
                else return;
            }
        }
    }
}
