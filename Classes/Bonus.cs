using System.Globalization;

namespace Classes
{
    public class Bonus
    {
        public int Amount { get; set; }
        public Dictionary<string, int> AddingHistory = new Dictionary<string, int>();

        public void AddBonuses(DateTime date, int moneySpend)
        {
            if (date == DateTime.MinValue)
            {
                date = DateTime.Now;
            }

            int bonus = (int)(moneySpend * 0.1);
            string dateKey = date.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            while (AddingHistory.ContainsKey(dateKey))
            {
                date = date.AddMilliseconds(1);
                dateKey = date.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            }

            AddingHistory[dateKey] = bonus;
            Amount += bonus;
        }

        public void WithdrawBonuses(int amountToWithdraw)
        {
            if (amountToWithdraw <= 0 || Amount < amountToWithdraw)
                return;

            var sortedEntries = AddingHistory
                .OrderBy(x => DateTime.ParseExact(x.Key, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture))
                .ToList();

            int remainingToWithdraw = amountToWithdraw;

            foreach (var entry in sortedEntries)
            {
                if (remainingToWithdraw <= 0) break;

                int bonusInEntry = entry.Value;
                if (bonusInEntry == 0) continue;

                if (bonusInEntry >= remainingToWithdraw)
                {
                    AddingHistory[entry.Key] = bonusInEntry - remainingToWithdraw;
                    Amount -= remainingToWithdraw;
                    remainingToWithdraw = 0;
                }
                else
                {
                    AddingHistory[entry.Key] = 0;
                    Amount -= bonusInEntry;
                    remainingToWithdraw -= bonusInEntry;
                }
            }

            var zeroEntries = AddingHistory.Where(x => x.Value == 0).ToList();
            foreach (var entry in zeroEntries)
            {
                AddingHistory.Remove(entry.Key);
            }
        }

        public void ClearBonuses()
        {
            var expiredEntries = AddingHistory.Where(x => DateTime.ParseExact(x.Key.Split('.')[0], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture) < DateTime.Now.AddDays(-3)).ToList();

            foreach (var entry in expiredEntries)
            {
                Amount -= entry.Value;
                AddingHistory.Remove(entry.Key);
            }
        }
    }
}