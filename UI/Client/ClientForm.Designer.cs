namespace UI
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            goodsList = new ListBox();
            label1 = new Label();
            buttonAdd = new Button();
            cartList = new ListBox();
            label2 = new Label();
            buttonRemove = new Button();
            userInfo = new RichTextBox();
            label3 = new Label();
            purchaceSum = new TextBox();
            buttonPayment = new Button();
            amountInCart = new NumericUpDown();
            label4 = new Label();
            label5 = new Label();
            buttonConfirmValue = new Button();
            ((System.ComponentModel.ISupportInitialize)amountInCart).BeginInit();
            SuspendLayout();
            // 
            // goodsList
            // 
            goodsList.FormattingEnabled = true;
            goodsList.ItemHeight = 15;
            goodsList.Location = new Point(8, 34);
            goodsList.Margin = new Padding(2, 1, 2, 1);
            goodsList.Name = "goodsList";
            goodsList.Size = new Size(131, 214);
            goodsList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 1;
            label1.Text = "Товары";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(143, 210);
            buttonAdd.Margin = new Padding(2, 1, 2, 1);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(81, 38);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Добавить в корзину";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // cartList
            // 
            cartList.FormattingEnabled = true;
            cartList.ItemHeight = 15;
            cartList.Location = new Point(444, 34);
            cartList.Margin = new Padding(2, 1, 2, 1);
            cartList.Name = "cartList";
            cartList.Size = new Size(131, 214);
            cartList.TabIndex = 3;
            cartList.SelectedIndexChanged += CartList_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(442, 5);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 28);
            label2.TabIndex = 4;
            label2.Text = "Корзина";
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(359, 210);
            buttonRemove.Margin = new Padding(2, 1, 2, 1);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(81, 38);
            buttonRemove.TabIndex = 5;
            buttonRemove.Text = "Удалить из корзины";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // userInfo
            // 
            userInfo.Location = new Point(164, 18);
            userInfo.Margin = new Padding(2, 1, 2, 1);
            userInfo.Name = "userInfo";
            userInfo.ReadOnly = true;
            userInfo.Size = new Size(252, 86);
            userInfo.TabIndex = 6;
            userInfo.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(359, 250);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 7;
            label3.Text = "Сумма:";
            // 
            // purchaceSum
            // 
            purchaceSum.Location = new Point(442, 255);
            purchaceSum.Margin = new Padding(2, 1, 2, 1);
            purchaceSum.Name = "purchaceSum";
            purchaceSum.ReadOnly = true;
            purchaceSum.Size = new Size(131, 23);
            purchaceSum.TabIndex = 8;
            purchaceSum.Text = "0";
            // 
            // buttonPayment
            // 
            buttonPayment.Location = new Point(444, 280);
            buttonPayment.Margin = new Padding(2, 1, 2, 1);
            buttonPayment.Name = "buttonPayment";
            buttonPayment.Size = new Size(129, 23);
            buttonPayment.TabIndex = 9;
            buttonPayment.Text = "Перейти к оплате";
            buttonPayment.UseVisualStyleBackColor = true;
            buttonPayment.Click += buttonPayment_Click;
            // 
            // amountInCart
            // 
            amountInCart.Location = new Point(345, 141);
            amountInCart.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            amountInCart.Name = "amountInCart";
            amountInCart.Size = new Size(71, 23);
            amountInCart.TabIndex = 10;
            amountInCart.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(345, 108);
            label4.Name = "label4";
            label4.Size = new Size(72, 30);
            label4.TabIndex = 11;
            label4.Text = "Изменение \r\nколичества";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 123);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 12;
            label5.Text = "<";
            // 
            // buttonConfirmValue
            // 
            buttonConfirmValue.Location = new Point(346, 170);
            buttonConfirmValue.Name = "buttonConfirmValue";
            buttonConfirmValue.Size = new Size(71, 23);
            buttonConfirmValue.TabIndex = 13;
            buttonConfirmValue.Text = "Изменить";
            buttonConfirmValue.UseVisualStyleBackColor = true;
            buttonConfirmValue.Click += buttonConfirmValue_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 313);
            Controls.Add(buttonConfirmValue);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(amountInCart);
            Controls.Add(buttonPayment);
            Controls.Add(purchaceSum);
            Controls.Add(label3);
            Controls.Add(userInfo);
            Controls.Add(buttonRemove);
            Controls.Add(label2);
            Controls.Add(cartList);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(goodsList);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ClientForm";
            Text = "ClientForm";
            ((System.ComponentModel.ISupportInitialize)amountInCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox goodsList;
        private Label label1;
        private Button buttonAdd;
        private ListBox cartList;
        private Label label2;
        private Button buttonRemove;
        private RichTextBox userInfo;
        private Label label3;
        private TextBox purchaceSum;
        private Button buttonPayment;
        private NumericUpDown amountInCart;
        private Label label4;
        private Label label5;
        private Button buttonConfirmValue;
    }
}