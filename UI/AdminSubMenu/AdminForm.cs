using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AdminForm : Form
    {
        private List<Goods> goods;
        private List<Client> clients;

        public AdminForm(List<Goods> goods, List<Client> clients)
        {
            InitializeComponent();

            this.goods = goods;
            this.clients = clients;
        }

        private void buttonAdminClient_Click(object sender, EventArgs e)
        {
            //openForm();
        }

        private void buttonAdminProduct_Click(object sender, EventArgs e)
        {
            new AdminProductForm(goods).ShowDialog();
        }
    }
}
