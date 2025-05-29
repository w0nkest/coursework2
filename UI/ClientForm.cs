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
    public partial class ClientForm : Form, IClient
    {
        ClientPresenter presenter;

        public ClientForm()
        {
            InitializeComponent();
            presenter = new ClientPresenter(this);
        }

        public void setUserText(string msg)
        {
            userInfo.Text = msg;
        }

        public void setSum(string msg)
        {
            purchaceSum.Text = msg;
        }

        public void addToProductList(Goods goods)
        {
            goodsList.Items.Add(goods);
        }

        public void addToCart(Goods goods)
        {
            cartList.Items.Add(goods);
        }

        public void removeFromCart(Goods goods)
        {
            cartList.Items.Remove(goods);
        }

        public List<Goods> getCart()
        {
            List<Goods> cart = new List<Goods>();
            foreach (Goods good in cartList.Items)
            {
                cart.Add(good);
            }
            return cart;
        }

        private void buttonPayment_Click(object sender, EventArgs e)
        {
            //Form form = new Form();
            //form.ShowDialog();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Goods selected = cartList.SelectedItem as Goods;
            presenter.cartRemoving(selected);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            presenter.cartAdding(goodsList.SelectedItem as Goods);
        }

        private void buttonConfirmValue_Click(object sender, EventArgs e)
        {
            if (cartList.SelectedItem is not null)
                presenter.cartAdding(cartList.SelectedItem as Goods, (int)amountInCart.Value);
            amountInCart.Value = 1;
        }
    }
}
