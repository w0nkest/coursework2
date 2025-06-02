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
    public partial class MenuForm : Form
    {
        private List<Goods> goods;
        private List<Client> clients;

        public MenuForm(List<Client> clients, List<Goods> good)
        {
            InitializeComponent();

            this.goods = good;
            this.clients = clients;
        }

        private void openForm(Form form)
        {
            form.ShowDialog();
        }

        private void buttonAdministration_Click(object sender, EventArgs e)
        {
            openForm(new AdminForm());
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            openForm(new ClientChoosingForm(clients, goods));
        }
    }
}
