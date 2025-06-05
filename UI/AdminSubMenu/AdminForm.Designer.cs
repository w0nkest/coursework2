namespace UI
{
    partial class AdminForm
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
            buttonAdminClient = new Button();
            buttonAdminProduct = new Button();
            SuspendLayout();
            // 
            // buttonAdminClient
            // 
            buttonAdminClient.BackColor = Color.Transparent;
            buttonAdminClient.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdminClient.ForeColor = Color.White;
            buttonAdminClient.Location = new Point(12, 30);
            buttonAdminClient.Margin = new Padding(3, 2, 3, 2);
            buttonAdminClient.Name = "buttonAdminClient";
            buttonAdminClient.Size = new Size(163, 42);
            buttonAdminClient.TabIndex = 0;
            buttonAdminClient.Text = "Администрирование клиетов";
            buttonAdminClient.UseVisualStyleBackColor = false;
            buttonAdminClient.Click += buttonAdminClient_Click;
            // 
            // buttonAdminProduct
            // 
            buttonAdminProduct.BackColor = Color.Transparent;
            buttonAdminProduct.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdminProduct.ForeColor = Color.White;
            buttonAdminProduct.Location = new Point(12, 94);
            buttonAdminProduct.Margin = new Padding(3, 2, 3, 2);
            buttonAdminProduct.Name = "buttonAdminProduct";
            buttonAdminProduct.Size = new Size(163, 42);
            buttonAdminProduct.TabIndex = 1;
            buttonAdminProduct.Text = "Администрирование продуктов";
            buttonAdminProduct.UseVisualStyleBackColor = false;
            buttonAdminProduct.Click += buttonAdminProduct_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.banya8;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(260, 159);
            Controls.Add(buttonAdminProduct);
            Controls.Add(buttonAdminClient);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminForm";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdminClient;
        private Button buttonAdminProduct;
    }
}