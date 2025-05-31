namespace UI
{
    partial class PaymentForm
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
            label1 = new Label();
            purchaceSum = new TextBox();
            label2 = new Label();
            userInfo = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxLefttoPay = new TextBox();
            label6 = new Label();
            numericUpDownCard = new NumericUpDown();
            numericUpDownCash = new NumericUpDown();
            numericUpDownBonus = new NumericUpDown();
            buttonPaymentViaParams = new Button();
            buttonPayWithCardOnly = new Button();
            buttonPayWithCashOnly = new Button();
            buttonBack = new Button();
            userInfoToLeft = new RichTextBox();
            label7 = new Label();
            buttonPayWithBonusOnly = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCash).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBonus).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 28);
            label1.TabIndex = 5;
            label1.Text = "Сумма:";
            // 
            // purchaceSum
            // 
            purchaceSum.Location = new Point(89, 14);
            purchaceSum.Margin = new Padding(2, 1, 2, 1);
            purchaceSum.Name = "purchaceSum";
            purchaceSum.ReadOnly = true;
            purchaceSum.Size = new Size(131, 23);
            purchaceSum.TabIndex = 9;
            purchaceSum.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(11, 67);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 10;
            label2.Text = "Ваш баланс:";
            // 
            // userInfo
            // 
            userInfo.Location = new Point(11, 96);
            userInfo.Margin = new Padding(2, 1, 2, 1);
            userInfo.Name = "userInfo";
            userInfo.ReadOnly = true;
            userInfo.Size = new Size(209, 103);
            userInfo.TabIndex = 11;
            userInfo.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 55);
            label3.Name = "label3";
            label3.Size = new Size(95, 30);
            label3.TabIndex = 15;
            label3.Text = "Укажите сумму \r\nоплаты картой";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 55);
            label4.Name = "label4";
            label4.Size = new Size(117, 30);
            label4.TabIndex = 16;
            label4.Text = "Укажите сумму \r\nоплаты наличными";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 55);
            label5.Name = "label5";
            label5.Size = new Size(106, 30);
            label5.TabIndex = 17;
            label5.Text = "Укажите сумму \r\nоплаты бонусами";
            // 
            // textBoxLefttoPay
            // 
            textBoxLefttoPay.Location = new Point(631, 96);
            textBoxLefttoPay.Margin = new Padding(2, 1, 2, 1);
            textBoxLefttoPay.Name = "textBoxLefttoPay";
            textBoxLefttoPay.ReadOnly = true;
            textBoxLefttoPay.Size = new Size(100, 23);
            textBoxLefttoPay.TabIndex = 18;
            textBoxLefttoPay.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(631, 55);
            label6.Name = "label6";
            label6.Size = new Size(71, 30);
            label6.TabIndex = 19;
            label6.Text = "Осталось к \r\nоплате";
            // 
            // numericUpDownCard
            // 
            numericUpDownCard.Location = new Point(242, 98);
            numericUpDownCard.Name = "numericUpDownCard";
            numericUpDownCard.Size = new Size(95, 23);
            numericUpDownCard.TabIndex = 20;
            numericUpDownCard.ValueChanged += numericCard_Changed;
            // 
            // numericUpDownCash
            // 
            numericUpDownCash.Location = new Point(373, 98);
            numericUpDownCash.Name = "numericUpDownCash";
            numericUpDownCash.Size = new Size(95, 23);
            numericUpDownCash.TabIndex = 21;
            numericUpDownCash.ValueChanged += numericCash_Changed;
            // 
            // numericUpDownBonus
            // 
            numericUpDownBonus.Location = new Point(502, 97);
            numericUpDownBonus.Name = "numericUpDownBonus";
            numericUpDownBonus.Size = new Size(95, 23);
            numericUpDownBonus.TabIndex = 22;
            numericUpDownBonus.ValueChanged += numericBonus_Changed;
            // 
            // buttonPaymentViaParams
            // 
            buttonPaymentViaParams.Location = new Point(631, 127);
            buttonPaymentViaParams.Name = "buttonPaymentViaParams";
            buttonPaymentViaParams.Size = new Size(100, 60);
            buttonPaymentViaParams.TabIndex = 23;
            buttonPaymentViaParams.Text = "Оплатить ";
            buttonPaymentViaParams.UseVisualStyleBackColor = true;
            // 
            // buttonPayWithCardOnly
            // 
            buttonPayWithCardOnly.Location = new Point(242, 127);
            buttonPayWithCardOnly.Name = "buttonPayWithCardOnly";
            buttonPayWithCardOnly.Size = new Size(95, 60);
            buttonPayWithCardOnly.TabIndex = 26;
            buttonPayWithCardOnly.Text = "Полностью оплатить картой";
            buttonPayWithCardOnly.UseVisualStyleBackColor = true;
            buttonPayWithCardOnly.Click += buttonPayWithCardOnly_Click;
            // 
            // buttonPayWithCashOnly
            // 
            buttonPayWithCashOnly.Location = new Point(373, 127);
            buttonPayWithCashOnly.Name = "buttonPayWithCashOnly";
            buttonPayWithCashOnly.Size = new Size(95, 60);
            buttonPayWithCashOnly.TabIndex = 27;
            buttonPayWithCashOnly.Text = "Полностью оплатить наличными";
            buttonPayWithCashOnly.UseVisualStyleBackColor = true;
            buttonPayWithCashOnly.Click += buttonPayWithCashOnly_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(89, 41);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(131, 23);
            buttonBack.TabIndex = 28;
            buttonBack.Text = "Отменить покупку";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // userInfoToLeft
            // 
            userInfoToLeft.Location = new Point(11, 254);
            userInfoToLeft.Margin = new Padding(2, 1, 2, 1);
            userInfoToLeft.Name = "userInfoToLeft";
            userInfoToLeft.ReadOnly = true;
            userInfoToLeft.Size = new Size(224, 103);
            userInfoToLeft.TabIndex = 29;
            userInfoToLeft.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(11, 216);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(156, 28);
            label7.TabIndex = 30;
            label7.Text = "У вас останется:";
            // 
            // buttonPayWithBonusOnly
            // 
            buttonPayWithBonusOnly.Location = new Point(502, 127);
            buttonPayWithBonusOnly.Name = "buttonPayWithBonusOnly";
            buttonPayWithBonusOnly.Size = new Size(95, 60);
            buttonPayWithBonusOnly.TabIndex = 31;
            buttonPayWithBonusOnly.Text = "Полностью оплатить бонусами";
            buttonPayWithBonusOnly.UseVisualStyleBackColor = true;
            buttonPayWithBonusOnly.Click += ButtonPayWithBonusOnly_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(756, 365);
            Controls.Add(buttonPayWithBonusOnly);
            Controls.Add(label7);
            Controls.Add(userInfoToLeft);
            Controls.Add(buttonBack);
            Controls.Add(buttonPayWithCashOnly);
            Controls.Add(buttonPayWithCardOnly);
            Controls.Add(buttonPaymentViaParams);
            Controls.Add(numericUpDownBonus);
            Controls.Add(numericUpDownCash);
            Controls.Add(numericUpDownCard);
            Controls.Add(label6);
            Controls.Add(textBoxLefttoPay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(userInfo);
            Controls.Add(label2);
            Controls.Add(purchaceSum);
            Controls.Add(label1);
            Name = "PaymentForm";
            Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCash).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBonus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox purchaceSum;
        private Label label2;
        private RichTextBox userInfo;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxLefttoPay;
        private Label label6;
        private NumericUpDown numericUpDownCard;
        private NumericUpDown numericUpDownCash;
        private NumericUpDown numericUpDownBonus;
        private Button buttonPaymentViaParams;
        private Button buttonPayWithCardOnly;
        private Button buttonPayWithCashOnly;
        private Button buttonBack;
        private RichTextBox userInfoToLeft;
        private Label label7;
        private Button buttonPayWithBonusOnly;
    }
}