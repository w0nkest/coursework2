using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Classes
{
    public class ShopFacade
    {
        private readonly Client client;
        private readonly Wallet wallet;
        private readonly BankCard card;
        private readonly Bonus bonus;

        public ShopFacade(Client client)
        {
            this.client = client;
            wallet = client.wallet;
            card = wallet.bankCard;
            bonus = wallet.Bonuses;
        }

        public string GetName() => client.Name;

        public void AddCardMoney(int value) => client.ExecuteCommand(new CommandAddCard(card, value));

        public void WithdrawCardMoney(int value) => client.ExecuteCommand(new CommandWithdrawCard(card, value));

        public int GetCardMoney() => client.getCardMoney();

        public void AddCash(int value) => client.ExecuteCommand(new CommandAddCash(wallet, value));

        public void WithdrawCash(int value) => client.ExecuteCommand(new CommandWithdrawCash(wallet, value));

        public int GetCash() => client.getCashMoney();

        public void AddBonus(DateTime date, int value) => client.ExecuteCommand(new CommandAddBonus(bonus, date, value));

        public void WithdrawBonus(DateTime date, int value) => client.ExecuteCommand(new CommandWithdrawBonus(bonus, value));

        public int GetBonus() => client.getBonuses();
    }
}
