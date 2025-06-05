namespace UI
{
    partial class AdminClientForm
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
            clientList = new ListBox();
            textBoxName = new TextBox();
            textBoxCard = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxCash = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBoxBonus = new TextBox();
            buttonAddCard = new Button();
            buttonWithdrawCard = new Button();
            buttonAddCash = new Button();
            buttonWithdrawCash = new Button();
            moneyToCard = new NumericUpDown();
            moneyCash = new NumericUpDown();
            buttonNewClient = new Button();
            textBoxNewName = new TextBox();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)moneyToCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)moneyCash).BeginInit();
            SuspendLayout();
            // 
            // clientList
            // 
            clientList.BackColor = Color.Green;
            clientList.BorderStyle = BorderStyle.None;
            clientList.FormattingEnabled = true;
            clientList.ItemHeight = 15;
            clientList.Location = new Point(12, 12);
            clientList.Name = "clientList";
            clientList.Size = new Size(120, 240);
            clientList.TabIndex = 0;
            clientList.SelectedIndexChanged += clientList_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.Window;
            textBoxName.Location = new Point(138, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxCard
            // 
            textBoxCard.BackColor = SystemColors.Window;
            textBoxCard.Location = new Point(244, 50);
            textBoxCard.Name = "textBoxCard";
            textBoxCard.ReadOnly = true;
            textBoxCard.Size = new Size(100, 23);
            textBoxCard.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(138, 23);
            label1.Name = "label1";
            label1.Size = new Size(35, 17);
            label1.TabIndex = 3;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(244, 23);
            label2.Name = "label2";
            label2.Size = new Size(95, 17);
            label2.TabIndex = 4;
            label2.Text = "Баланс карты";
            // 
            // textBoxCash
            // 
            textBoxCash.BackColor = SystemColors.Window;
            textBoxCash.Location = new Point(350, 50);
            textBoxCash.Name = "textBoxCash";
            textBoxCash.ReadOnly = true;
            textBoxCash.Size = new Size(100, 23);
            textBoxCash.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(350, 23);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 6;
            label3.Text = "Наличные";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(456, 23);
            label4.Name = "label4";
            label4.Size = new Size(56, 17);
            label4.TabIndex = 7;
            label4.Text = "Бонусы";
            // 
            // textBoxBonus
            // 
            textBoxBonus.BackColor = SystemColors.Window;
            textBoxBonus.Location = new Point(456, 50);
            textBoxBonus.Name = "textBoxBonus";
            textBoxBonus.ReadOnly = true;
            textBoxBonus.Size = new Size(100, 23);
            textBoxBonus.TabIndex = 8;
            // 
            // buttonAddCard
            // 
            buttonAddCard.Location = new Point(244, 79);
            buttonAddCard.Name = "buttonAddCard";
            buttonAddCard.Size = new Size(100, 40);
            buttonAddCard.TabIndex = 9;
            buttonAddCard.Text = "Пополнить карту";
            buttonAddCard.UseVisualStyleBackColor = true;
            buttonAddCard.Click += buttonAddCard_Click;
            // 
            // buttonWithdrawCard
            // 
            buttonWithdrawCard.Location = new Point(244, 125);
            buttonWithdrawCard.Name = "buttonWithdrawCard";
            buttonWithdrawCard.Size = new Size(100, 40);
            buttonWithdrawCard.TabIndex = 10;
            buttonWithdrawCard.Text = "Снять с карты";
            buttonWithdrawCard.UseVisualStyleBackColor = true;
            buttonWithdrawCard.Click += buttonWithdrawCard_Click;
            // 
            // buttonAddCash
            // 
            buttonAddCash.Location = new Point(350, 79);
            buttonAddCash.Name = "buttonAddCash";
            buttonAddCash.Size = new Size(100, 40);
            buttonAddCash.TabIndex = 11;
            buttonAddCash.Text = "Добавить наличные";
            buttonAddCash.UseVisualStyleBackColor = true;
            buttonAddCash.Click += buttonAddCash_Click;
            // 
            // buttonWithdrawCash
            // 
            buttonWithdrawCash.Location = new Point(350, 125);
            buttonWithdrawCash.Name = "buttonWithdrawCash";
            buttonWithdrawCash.Size = new Size(100, 40);
            buttonWithdrawCash.TabIndex = 12;
            buttonWithdrawCash.Text = "Убавить наличные";
            buttonWithdrawCash.UseVisualStyleBackColor = true;
            buttonWithdrawCash.Click += buttonWithdrawCash_Click;
            // 
            // moneyToCard
            // 
            moneyToCard.Location = new Point(244, 171);
            moneyToCard.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            moneyToCard.Name = "moneyToCard";
            moneyToCard.Size = new Size(100, 23);
            moneyToCard.TabIndex = 13;
            // 
            // moneyCash
            // 
            moneyCash.Location = new Point(350, 171);
            moneyCash.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            moneyCash.Name = "moneyCash";
            moneyCash.Size = new Size(100, 23);
            moneyCash.TabIndex = 14;
            // 
            // buttonNewClient
            // 
            buttonNewClient.Location = new Point(138, 233);
            buttonNewClient.Name = "buttonNewClient";
            buttonNewClient.Size = new Size(120, 23);
            buttonNewClient.TabIndex = 15;
            buttonNewClient.Text = "Добавить клиента";
            buttonNewClient.UseVisualStyleBackColor = true;
            buttonNewClient.Click += buttonNewClient_Click;
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new Point(138, 204);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(120, 23);
            textBoxNewName.TabIndex = 16;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(138, 79);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 40);
            buttonDelete.TabIndex = 17;
            buttonDelete.Text = "Удалить клиента";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // AdminClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.banya9;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(564, 264);
            Controls.Add(buttonDelete);
            Controls.Add(textBoxNewName);
            Controls.Add(buttonNewClient);
            Controls.Add(moneyCash);
            Controls.Add(moneyToCard);
            Controls.Add(buttonWithdrawCash);
            Controls.Add(buttonAddCash);
            Controls.Add(buttonWithdrawCard);
            Controls.Add(buttonAddCard);
            Controls.Add(textBoxBonus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxCash);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCard);
            Controls.Add(textBoxName);
            Controls.Add(clientList);
            Name = "AdminClientForm";
            Text = "AdminClient";
            ((System.ComponentModel.ISupportInitialize)moneyToCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)moneyCash).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox clientList;
        private TextBox textBoxName;
        private TextBox textBoxCard;
        private Label label1;
        private Label label2;
        private TextBox textBoxCash;
        private Label label3;
        private Label label4;
        private TextBox textBoxBonus;
        private Button buttonAddCard;
        private Button buttonWithdrawCard;
        private Button buttonAddCash;
        private Button buttonWithdrawCash;
        private NumericUpDown moneyToCard;
        private NumericUpDown moneyCash;
        private Button buttonNewClient;
        private TextBox textBoxNewName;
        private Button buttonDelete;
    }
}