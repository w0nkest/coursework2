using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace UI
{
    public partial class PaymentForm : Form, IPayment
    {
        private int receivedSum;
        private ClientFacade client;
        private PaymentPresenter presenter;
        private List<Goods> goods;

        public PaymentForm(int receivedSum, ClientFacade client, List<Goods> goods)
        {
            InitializeComponent();

            numericUpDownCard.Maximum = client.GetCardMoney();
            numericUpDownCash.Maximum = client.GetCash();
            numericUpDownBonus.Maximum = client.GetBonus();

            this.receivedSum = receivedSum;
            this.client = client;
            this.goods = new List<Goods>(goods);

            presenter = new PaymentPresenter(this, client);
        }

        private void buttonPaymentViaParams_Click(object sender, EventArgs e)
        {
            presenter.paymentProcess(this);
        }

        private void ButtonPayWithBonusOnly_Click(object sender, EventArgs e)
        {
            presenter.bonusPayment();
        }

        private void buttonPayWithCashOnly_Click(object sender, EventArgs e)
        {
            presenter.cashPayment();
        }

        private void buttonPayWithCardOnly_Click(object sender, EventArgs e)
        {
            presenter.cardPayment();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            presenter.closeTab(this);
        }

        private void numericCard_Changed(object sender, EventArgs e)
        {
            presenter.outLeftInfo();
        }

        private void numericCash_Changed(object sender, EventArgs e)
        {
            presenter.outLeftInfo();
        }

        private void numericBonus_Changed(object sender, EventArgs e)
        {
            presenter.outLeftInfo();
        }

        public int getCardValue()
        {
            return (int)numericUpDownCard.Value;
        }

        public int getCashValue()
        {
            return (int)numericUpDownCash.Value;
        }

        public int getBonusValue()
        {
            return (int)numericUpDownBonus.Value;
        }

        public List<Goods> getCart()
        {
            return goods;
        }

        public void userInfo_SetText(string msg)
        {
            userInfo.Text = msg;
        }

        public void userInfoLeft_SetText(string msg)
        {
            userInfoToLeft.Text = msg;
        }

        public void setSum(string msg)
        {
            purchaceSum.Text = msg;
        }

        public void setSumLeft(string msg)
        {
            textBoxLefttoPay.Text = msg;
        }

        public void setCardSum(int value)
        {
            numericUpDownCard.Value = value;
        }
        
        public void setCashSum(int value)
        {
            numericUpDownCash.Value = value;
        }

        public void setBonusSum(int value)
        {
            numericUpDownBonus.Value = value;
        }

        public List<int> numericValues()
        {
            List<int> list = new List<int>();

            list.Add((int)numericUpDownCard.Value);
            list.Add((int)numericUpDownCash.Value);
            list.Add((int)numericUpDownBonus.Value);

            return list;
        }

        public void raiseMsgBox(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
