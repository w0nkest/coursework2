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
            buttonAdminClient.Location = new Point(70, 50);
            buttonAdminClient.Margin = new Padding(5);
            buttonAdminClient.Name = "buttonAdminClient";
            buttonAdminClient.Size = new Size(270, 90);
            buttonAdminClient.TabIndex = 0;
            buttonAdminClient.Text = "Администрирование клиетов";
            buttonAdminClient.UseVisualStyleBackColor = true;
            buttonAdminClient.Click += buttonAdminClient_Click;
            // 
            // buttonAdminProduct
            // 
            buttonAdminProduct.Location = new Point(70, 180);
            buttonAdminProduct.Margin = new Padding(5);
            buttonAdminProduct.Name = "buttonAdminProduct";
            buttonAdminProduct.Size = new Size(270, 90);
            buttonAdminProduct.TabIndex = 1;
            buttonAdminProduct.Text = "Администрирование продуктов";
            buttonAdminProduct.UseVisualStyleBackColor = true;
            buttonAdminProduct.Click += buttonAdminProduct_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 329);
            Controls.Add(buttonAdminProduct);
            Controls.Add(buttonAdminClient);
            Name = "Admin";
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdminClient;
        private Button buttonAdminProduct;
    }
}