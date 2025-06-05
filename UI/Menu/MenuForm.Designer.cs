namespace UI
{
    partial class MenuForm
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
            buttonAdministration = new Button();
            buttonClient = new Button();
            SuspendLayout();
            // 
            // buttonAdministration
            // 
            buttonAdministration.BackColor = Color.PapayaWhip;
            buttonAdministration.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAdministration.ForeColor = Color.Olive;
            buttonAdministration.Location = new Point(70, 50);
            buttonAdministration.Margin = new Padding(5);
            buttonAdministration.Name = "buttonAdministration";
            buttonAdministration.Size = new Size(281, 90);
            buttonAdministration.TabIndex = 0;
            buttonAdministration.Text = "Администрирование";
            buttonAdministration.UseVisualStyleBackColor = false;
            buttonAdministration.Click += buttonAdministration_Click;
            // 
            // buttonClient
            // 
            buttonClient.BackColor = Color.PapayaWhip;
            buttonClient.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClient.ForeColor = Color.Olive;
            buttonClient.Location = new Point(70, 180);
            buttonClient.Margin = new Padding(5);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(281, 90);
            buttonClient.TabIndex = 1;
            buttonClient.Text = "Совершить покупку";
            buttonClient.UseVisualStyleBackColor = false;
            buttonClient.Click += buttonClient_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.banya3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(413, 329);
            Controls.Add(buttonClient);
            Controls.Add(buttonAdministration);
            Name = "MenuForm";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdministration;
        private Button buttonClient;
    }
}