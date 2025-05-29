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
        public AdminForm()
        {
            InitializeComponent();
        }

        private void openForm(Form form)
        {
            form.ShowDialog();
        }

        private void buttonAdminClient_Click(object sender, EventArgs e)
        {
            //openForm();
        }

        private void buttonAdminProduct_Click(object sender, EventArgs e)
        {
            //openForm();
        }
    }
}
