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
    public partial class AdminClientForm : Form, IAdminClient
    {
        private List<Client> clients;
        private AdminClientPresenter presenter;

        public AdminClientForm(List<Client> clients)
        {
            InitializeComponent();

            this.clients = clients;

            presenter = new AdminClientPresenter(this);
        }
    }
}
