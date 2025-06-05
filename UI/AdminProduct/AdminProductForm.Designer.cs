namespace UI
{
    partial class AdminProductForm
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
            productList = new ListBox();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonAccept = new Button();
            info = new RichTextBox();
            buttonDelete = new Button();
            buttonAdd = new Button();
            isTime = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // productList
            // 
            productList.BackColor = Color.SaddleBrown;
            productList.BorderStyle = BorderStyle.None;
            productList.FormattingEnabled = true;
            productList.ItemHeight = 15;
            productList.Location = new Point(12, 12);
            productList.Name = "productList";
            productList.Size = new Size(223, 210);
            productList.TabIndex = 0;
            productList.SelectedIndexChanged += productList_SelectedIndexChanged;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.Chocolate;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Location = new Point(241, 32);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 16);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.BackColor = Color.Chocolate;
            textBoxPrice.BorderStyle = BorderStyle.None;
            textBoxPrice.Location = new Point(347, 32);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 16);
            textBoxPrice.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(68, 17);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.White;
            label2.Location = new Point(347, 9);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 4;
            label2.Text = "Цена";
            // 
            // buttonAccept
            // 
            buttonAccept.Location = new Point(347, 54);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(100, 41);
            buttonAccept.TabIndex = 5;
            buttonAccept.Text = "Принять изменения";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // info
            // 
            info.BackColor = Color.SaddleBrown;
            info.BorderStyle = BorderStyle.FixedSingle;
            info.Location = new Point(241, 148);
            info.Name = "info";
            info.ReadOnly = true;
            info.Size = new Size(312, 74);
            info.TabIndex = 6;
            info.Text = "";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(241, 54);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 41);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(453, 54);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 41);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // isTime
            // 
            isTime.AutoSize = true;
            isTime.BackColor = Color.Transparent;
            isTime.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            isTime.ForeColor = Color.White;
            isTime.Location = new Point(258, 105);
            isTime.Name = "isTime";
            isTime.Size = new Size(91, 38);
            isTime.TabIndex = 9;
            isTime.Text = "Услуга по \r\nвремени";
            isTime.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.White;
            label3.Location = new Point(386, 105);
            label3.Name = "label3";
            label3.Size = new Size(162, 34);
            label3.TabIndex = 10;
            label3.Text = "Используется только \r\nпри добавления нового";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.White;
            label4.Location = new Point(365, 114);
            label4.Name = "label4";
            label4.Size = new Size(17, 17);
            label4.TabIndex = 11;
            label4.Text = "<";
            // 
            // AdminProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.banya7;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(558, 233);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(isTime);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDelete);
            Controls.Add(info);
            Controls.Add(buttonAccept);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(productList);
            Name = "AdminProductForm";
            Text = "AdminProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox productList;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Label label1;
        private Label label2;
        private Button buttonAccept;
        private RichTextBox info;
        private Button buttonDelete;
        private Button buttonAdd;
        private CheckBox isTime;
        private Label label3;
        private Label label4;
    }
}