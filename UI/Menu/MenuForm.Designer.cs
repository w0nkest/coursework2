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
            buttonAdministration.Location = new Point(70, 50);
            buttonAdministration.Margin = new Padding(5);
            buttonAdministration.Name = "buttonAdministration";
            buttonAdministration.Size = new Size(270, 90);
            buttonAdministration.TabIndex = 0;
            buttonAdministration.Text = "Администрирование";
            buttonAdministration.UseVisualStyleBackColor = true;
            buttonAdministration.Click += buttonAdministration_Click;
            // 
            // buttonClient
            // 
            buttonClient.Location = new Point(70, 180);
            buttonClient.Margin = new Padding(5);
            buttonClient.Name = "buttonClient";
            buttonClient.Size = new Size(270, 90);
            buttonClient.TabIndex = 1;
            buttonClient.Text = "Совершить покупку";
            buttonClient.UseVisualStyleBackColor = true;
            buttonClient.Click += buttonClient_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 329);
            Controls.Add(buttonClient);
            Controls.Add(buttonAdministration);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdministration;
        private Button buttonClient;
    }
}