namespace UI
{
    partial class ClientChoosingForm
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
            label1 = new Label();
            buttonSelect = new Button();
            buttonNotExist = new Button();
            SuspendLayout();
            // 
            // clientList
            // 
            clientList.FormattingEnabled = true;
            clientList.Location = new Point(13, 85);
            clientList.Name = "clientList";
            clientList.Size = new Size(240, 324);
            clientList.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 57);
            label1.TabIndex = 2;
            label1.Text = "Клиенты";
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(259, 327);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(180, 82);
            buttonSelect.TabIndex = 3;
            buttonSelect.Text = "Выбрать";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // buttonNotExist
            // 
            buttonNotExist.Location = new Point(259, 239);
            buttonNotExist.Name = "buttonNotExist";
            buttonNotExist.Size = new Size(180, 82);
            buttonNotExist.TabIndex = 4;
            buttonNotExist.Text = "Меня нет в списке";
            buttonNotExist.UseVisualStyleBackColor = true;
            buttonNotExist.Click += buttonNotExist_Click;
            // 
            // ClientChoosingForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 417);
            Controls.Add(buttonNotExist);
            Controls.Add(buttonSelect);
            Controls.Add(label1);
            Controls.Add(clientList);
            Name = "ClientChoosingForm";
            Text = "ClientChoosingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox clientList;
        private Label label1;
        private Button buttonSelect;
        private Button buttonNotExist;
    }
}