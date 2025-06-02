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
    public partial class ClientChoosingForm : Form, IClientChoosing
    {
        private List<Client> clients;
        private ClientChoosingPresenter presenter;
        private List<Goods> goods;

        public ClientChoosingForm(List<Client> clients, List<Goods> goods)
        {
            InitializeComponent();

            this.clients = clients;
            this.goods = goods;
            presenter = new ClientChoosingPresenter(this, clients);
        }

        public void clientListUpdate(Client client)
        {
            clientList.Items.Add(client);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            presenter.openNewTab(goods, clientList.SelectedItem as Client);
        }

        private void buttonNotExist_Click(object sender, EventArgs e)
        {
            presenter.closeTab(this);
        }

        public void raiseMsgBox(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
