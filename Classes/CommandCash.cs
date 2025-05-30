using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CommandAddCash : ICommand
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

    public class CommandWithdrawCash : ICommand
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
