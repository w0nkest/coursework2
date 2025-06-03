using Classes;

namespace UI
{
    public partial class AdminClientForm : Form, IAdminClient
    {
        private List<ClientFacade> clients;
        private AdminClientPresenter presenter;

        public AdminClientForm(List<ClientFacade> clients)
        {
            InitializeComponent();

            this.clients = clients;

            presenter = new AdminClientPresenter(this, clients);
        }

        public void setMaxToNumerics(int maxcard, int maxcash)
        {
            moneyToCard.Maximum = maxcard;
            moneyCash.Maximum = maxcash;
        }

        public void clientListSet(ClientFacade client)
        {
            clientList.Items.Add(client);
        }

        public void clientListRemove(ClientFacade client)
        {
            clientList.Items.Remove(client);
            clients.Remove(client);
        }

        public void clientListAdd(ClientFacade client)
        {
            clientList.Items.Add(client);
            clients.Add(client);
        }

        public void textBoxNameSet(string msg)
        {
            textBoxName.Text = msg;
        }

        public void textBoxCardSet(string msg)
        {
            textBoxCard.Text = msg;
        }

        public void textBoxCashSet(string msg)
        {
            textBoxCash.Text = msg;
        }

        public void textBoxBonusSet(string msg)
        {
            textBoxBonus.Text = msg;
        }

        public void raiseMsgBox(string msg)
        {
            MessageBox.Show(msg);
        }

        private void clientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientList.SelectedItem is not null)
                presenter.setSelectedData(clientList.SelectedItem as ClientFacade);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            presenter.deletingClient(clientList.SelectedItem as ClientFacade);
        }

        private void buttonNewClient_Click(object sender, EventArgs e)
        {
            presenter.addingClient(textBoxNewName.Text);
            textBoxNewName.Text = "";
        }

        private void buttonAddCard_Click(object sender, EventArgs e)
        {
            presenter.cardTransaction(clientList.SelectedItem as ClientFacade, (int)moneyToCard.Value, true);
            moneyToCard.Value = 0;
        }

        private void buttonWithdrawCard_Click(object sender, EventArgs e)
        {
            presenter.cardTransaction(clientList.SelectedItem as ClientFacade, (int)moneyToCard.Value, false);
            moneyToCard.Value = 0;
        }

        private void buttonAddCash_Click(object sender, EventArgs e)
        {
            presenter.cashTransaction(clientList.SelectedItem as ClientFacade, (int)moneyCash.Value, true);
            moneyCash.Value = 0;
        }

        private void buttonWithdrawCash_Click(object sender, EventArgs e)
        {
            presenter.cashTransaction(clientList.SelectedItem as ClientFacade, (int)moneyCash.Value, false);
            moneyCash.Value = 0;
        }
    }
}
