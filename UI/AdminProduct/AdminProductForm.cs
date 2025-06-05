using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Classes;

namespace UI
{
    public partial class AdminProductForm : Form, IAdminProduct
    {
        private List<Goods> goods;
        private AdminProductPresenter presenter;

        public AdminProductForm(List<Goods> goods)
        {
            InitializeComponent();

            this.goods = goods;
            presenter = new AdminProductPresenter(this, goods);
        }

        public void setInfoText(string msg)
        {
            info.Text = msg;
        }

        public void setName(string msg)
        {
            textBoxName.Text = msg;
        }

        public void setPrice(string msg)
        {
            textBoxPrice.Text = msg;
        }

        public void productListAdd(Goods good)
        {
            productList.Items.Add(good);
        }

        public void productListRemove(Goods good)
        {
            productList.Items.Remove(good);
        }

        public void raiseMsgBox(string msg)
        {
            MessageBox.Show(msg);
        }

        public void productListUpdate(Goods oldgood, Goods newgood)
        {
            int id = productList.Items.IndexOf(oldgood);

            if (id >= 0)
            {
                productList.Items[id] = newgood;
            }
        }

        private void productList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productList.SelectedItem is not null)
                presenter.setProductData(productList.SelectedItem as Goods);
            else { setName(""); setPrice(""); }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            presenter.updateProduct(productList.SelectedItem as Goods, textBoxName.Text, textBoxPrice.Text);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            presenter.createProduct(textBoxName.Text, textBoxPrice.Text, isTime.Checked);
            isTime.Checked = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            presenter.removeProduct(productList.SelectedItem as Goods);
        }
    }
}
