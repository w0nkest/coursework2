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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(20, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 57);
            label1.TabIndex = 5;
            label1.Text = "Сумма:";
            // 
            // purchaceSum
            // 
            purchaceSum.BackColor = Color.Peru;
            purchaceSum.BorderStyle = BorderStyle.None;
            purchaceSum.Location = new Point(165, 30);
            purchaceSum.Margin = new Padding(4, 2, 4, 2);
            purchaceSum.Name = "purchaceSum";
            purchaceSum.ReadOnly = true;
            purchaceSum.Size = new Size(240, 32);
            purchaceSum.TabIndex = 9;
            purchaceSum.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 143);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(227, 57);
            label2.TabIndex = 10;
            label2.Text = "Ваш баланс:";
            // 
            // userInfo
            // 
            userInfo.BackColor = Color.Peru;
            userInfo.BorderStyle = BorderStyle.None;
            userInfo.Location = new Point(20, 205);
            userInfo.Margin = new Padding(4, 2, 4, 2);
            userInfo.Name = "userInfo";
            userInfo.ReadOnly = true;
            userInfo.Size = new Size(385, 215);
            userInfo.TabIndex = 11;
            userInfo.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(449, 117);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(194, 64);
            label3.TabIndex = 15;
            label3.Text = "Укажите сумму \r\nоплаты картой";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(693, 117);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(235, 64);
            label4.TabIndex = 16;
            label4.Text = "Укажите сумму \r\nоплаты наличными";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(932, 117);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(213, 64);
            label5.TabIndex = 17;
            label5.Text = "Укажите сумму \r\nоплаты бонусами";
            // 
            // textBoxLefttoPay
            // 
            textBoxLefttoPay.BorderStyle = BorderStyle.None;
            textBoxLefttoPay.Location = new Point(1172, 205);
            textBoxLefttoPay.Margin = new Padding(4, 2, 4, 2);
            textBoxLefttoPay.Name = "textBoxLefttoPay";
            textBoxLefttoPay.ReadOnly = true;
            textBoxLefttoPay.Size = new Size(182, 32);
            textBoxLefttoPay.TabIndex = 18;
            textBoxLefttoPay.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(1172, 117);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(144, 64);
            label6.TabIndex = 19;
            label6.Text = "Осталось к \r\nоплате";
            // 
            // numericUpDownCard
            // 
            numericUpDownCard.BorderStyle = BorderStyle.None;
            numericUpDownCard.Location = new Point(449, 209);
            numericUpDownCard.Margin = new Padding(6, 6, 6, 6);
            numericUpDownCard.Name = "numericUpDownCard";
            numericUpDownCard.Size = new Size(176, 35);
            numericUpDownCard.TabIndex = 20;
            numericUpDownCard.ValueChanged += numericCard_Changed;
            // 
            // numericUpDownCash
            // 
            numericUpDownCash.BorderStyle = BorderStyle.None;
            numericUpDownCash.Location = new Point(693, 209);
            numericUpDownCash.Margin = new Padding(6, 6, 6, 6);
            numericUpDownCash.Name = "numericUpDownCash";
            numericUpDownCash.Size = new Size(176, 35);
            numericUpDownCash.TabIndex = 21;
            numericUpDownCash.ValueChanged += numericCash_Changed;
            // 
            // numericUpDownBonus
            // 
            numericUpDownBonus.BorderStyle = BorderStyle.None;
            numericUpDownBonus.Location = new Point(932, 207);
            numericUpDownBonus.Margin = new Padding(6, 6, 6, 6);
            numericUpDownBonus.Name = "numericUpDownBonus";
            numericUpDownBonus.Size = new Size(176, 35);
            numericUpDownBonus.TabIndex = 22;
            numericUpDownBonus.ValueChanged += numericBonus_Changed;
            // 
            // buttonPaymentViaParams
            // 
            buttonPaymentViaParams.Location = new Point(1172, 271);
            buttonPaymentViaParams.Margin = new Padding(6, 6, 6, 6);
            buttonPaymentViaParams.Name = "buttonPaymentViaParams";
            buttonPaymentViaParams.Size = new Size(186, 128);
            buttonPaymentViaParams.TabIndex = 23;
            buttonPaymentViaParams.Text = "Оплатить ";
            buttonPaymentViaParams.UseVisualStyleBackColor = true;
            buttonPaymentViaParams.Click += buttonPaymentViaParams_Click;
            // 
            // buttonPayWithCardOnly
            // 
            buttonPayWithCardOnly.Location = new Point(449, 271);
            buttonPayWithCardOnly.Margin = new Padding(6, 6, 6, 6);
            buttonPayWithCardOnly.Name = "buttonPayWithCardOnly";
            buttonPayWithCardOnly.Size = new Size(176, 128);
            buttonPayWithCardOnly.TabIndex = 26;
            buttonPayWithCardOnly.Text = "Полностью оплатить картой";
            buttonPayWithCardOnly.UseVisualStyleBackColor = true;
            buttonPayWithCardOnly.Click += buttonPayWithCardOnly_Click;
            // 
            // buttonPayWithCashOnly
            // 
            buttonPayWithCashOnly.Location = new Point(693, 271);
            buttonPayWithCashOnly.Margin = new Padding(6, 6, 6, 6);
            buttonPayWithCashOnly.Name = "buttonPayWithCashOnly";
            buttonPayWithCashOnly.Size = new Size(176, 128);
            buttonPayWithCashOnly.TabIndex = 27;
            buttonPayWithCashOnly.Text = "Полностью оплатить наличными";
            buttonPayWithCashOnly.UseVisualStyleBackColor = true;
            buttonPayWithCashOnly.Click += buttonPayWithCashOnly_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(165, 87);
            buttonBack.Margin = new Padding(6, 6, 6, 6);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(243, 49);
            buttonBack.TabIndex = 28;
            buttonBack.Text = "Отменить покупку";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // userInfoToLeft
            // 
            userInfoToLeft.BackColor = Color.Peru;
            userInfoToLeft.BorderStyle = BorderStyle.None;
            userInfoToLeft.Location = new Point(20, 542);
            userInfoToLeft.Margin = new Padding(4, 2, 4, 2);
            userInfoToLeft.Name = "userInfoToLeft";
            userInfoToLeft.ReadOnly = true;
            userInfoToLeft.Size = new Size(413, 215);
            userInfoToLeft.TabIndex = 29;
            userInfoToLeft.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(20, 461);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(319, 57);
            label7.TabIndex = 30;
            label7.Text = "У вас останется:";
            // 
            // buttonPayWithBonusOnly
            // 
            buttonPayWithBonusOnly.Location = new Point(932, 271);
            buttonPayWithBonusOnly.Margin = new Padding(6, 6, 6, 6);
            buttonPayWithBonusOnly.Name = "buttonPayWithBonusOnly";
            buttonPayWithBonusOnly.Size = new Size(176, 128);
            buttonPayWithBonusOnly.TabIndex = 31;
            buttonPayWithBonusOnly.Text = "Полностью оплатить бонусами";
            buttonPayWithBonusOnly.UseVisualStyleBackColor = true;
            buttonPayWithBonusOnly.Click += ButtonPayWithBonusOnly_Click;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.banya2__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1404, 779);
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
            Margin = new Padding(6, 6, 6, 6);
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