using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    internal interface IPaymentPresenter
    {
        void zeroingValues();

        public void cardPayment();

        public void cashPayment();

        public void bonusPayment();

        public void closeTab(Form form);

        public int calculateSum();

        public int calculateLeftSum();

        public void outLeftInfo();

        public void paymentProcess();
    }
}
