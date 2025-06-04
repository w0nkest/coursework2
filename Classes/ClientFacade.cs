namespace Classes
{
    public class ClientFacade
    {
        private readonly Client client;
        private readonly Wallet wallet;
        private readonly BankCard card;
        private readonly Bonus bonus;

        public ClientFacade(Client client)
        {
            this.client = client;
            wallet = client.wallet;
            card = wallet.bankCard;
            bonus = wallet.Bonuses;
        }

        public Wallet GetWallet()
        {
            return wallet;
        }

        public virtual Dictionary<string, int> IDs()
        {
            return new Dictionary<string, int> { { "cID", client.ID }, { "bID", card.ID} };
        }

        public string GetName() => client.Name;

        public void AddCardMoney(int value) => client.ExecuteCommand(new CommandAddCard(card, value));

        public void WithdrawCardMoney(int value) => client.ExecuteCommand(new CommandWithdrawCard(card, value));

        public int GetCardMoney() => client.getCardMoney();

        public void AddCash(int value) => client.ExecuteCommand(new CommandAddCash(wallet, value));

        public void WithdrawCash(int value) => client.ExecuteCommand(new CommandWithdrawCash(wallet, value));

        public int GetCash() => client.getCashMoney();

        public void AddBonus(DateTime date, int value) => client.ExecuteCommand(new CommandAddBonus(bonus, date, value));

        public void WithdrawBonus(int value) => client.ExecuteCommand(new CommandWithdrawBonus(bonus, value));

        public int GetBonus() => client.getBonuses();

        public override string ToString()
        {
            return GetName();
        }
    }
}
