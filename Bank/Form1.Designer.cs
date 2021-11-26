namespace Bank
{
    partial class Form1
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
            this.tcBanks = new System.Windows.Forms.TabControl();
            this.tabPageBankomat1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2_0 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTakeCheck_0 = new System.Windows.Forms.Button();
            this.btnTakeCash_0 = new System.Windows.Forms.Button();
            this.gbCard_0 = new System.Windows.Forms.GroupBox();
            this.btnInsertTakeCard_0 = new System.Windows.Forms.Button();
            this.rbCardInside_0 = new System.Windows.Forms.RadioButton();
            this.gbKeyboard_0 = new System.Windows.Forms.GroupBox();
            this.tbPass_0 = new System.Windows.Forms.TextBox();
            this.btnConfirm_0 = new System.Windows.Forms.Button();
            this.btnCancel_0 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1_0 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbMessage_0 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMainTosaving_0 = new System.Windows.Forms.Button();
            this.btnMainWithdraw_0 = new System.Windows.Forms.Button();
            this.tbMainAmount_0 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMainBalance_0 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSavingTomain_0 = new System.Windows.Forms.Button();
            this.btnSavingWithdraw_0 = new System.Windows.Forms.Button();
            this.tbSavingAmount_0 = new System.Windows.Forms.TextBox();
            this.tbSavingBalance_0 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCardInfo_0 = new System.Windows.Forms.GroupBox();
            this.groupBox1_0 = new System.Windows.Forms.GroupBox();
            this.tbCardExpDate_0 = new System.Windows.Forms.MaskedTextBox();
            this.gbCardNumber_0 = new System.Windows.Forms.GroupBox();
            this.tbCardNumber_0 = new System.Windows.Forms.MaskedTextBox();
            this.tabPageBankomat2 = new System.Windows.Forms.TabPage();
            this.tcBanks.SuspendLayout();
            this.tabPageBankomat1.SuspendLayout();
            this.flowLayoutPanel2_0.SuspendLayout();
            this.gbCard_0.SuspendLayout();
            this.gbKeyboard_0.SuspendLayout();
            this.flowLayoutPanel1_0.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCardInfo_0.SuspendLayout();
            this.groupBox1_0.SuspendLayout();
            this.gbCardNumber_0.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBanks
            // 
            this.tcBanks.Controls.Add(this.tabPageBankomat1);
            this.tcBanks.Controls.Add(this.tabPageBankomat2);
            this.tcBanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcBanks.Location = new System.Drawing.Point(0, 0);
            this.tcBanks.Name = "tcBanks";
            this.tcBanks.SelectedIndex = 0;
            this.tcBanks.Size = new System.Drawing.Size(887, 444);
            this.tcBanks.TabIndex = 0;
            // 
            // tabPageBankomat1
            // 
            this.tabPageBankomat1.Controls.Add(this.flowLayoutPanel2_0);
            this.tabPageBankomat1.Controls.Add(this.flowLayoutPanel1_0);
            this.tabPageBankomat1.Controls.Add(this.gbCardInfo_0);
            this.tabPageBankomat1.Location = new System.Drawing.Point(4, 26);
            this.tabPageBankomat1.Name = "tabPageBankomat1";
            this.tabPageBankomat1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBankomat1.Size = new System.Drawing.Size(879, 414);
            this.tabPageBankomat1.TabIndex = 0;
            this.tabPageBankomat1.Text = "Банкомат 1";
            this.tabPageBankomat1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2_0
            // 
            this.flowLayoutPanel2_0.Controls.Add(this.btnTakeCheck_0);
            this.flowLayoutPanel2_0.Controls.Add(this.btnTakeCash_0);
            this.flowLayoutPanel2_0.Controls.Add(this.gbCard_0);
            this.flowLayoutPanel2_0.Controls.Add(this.gbKeyboard_0);
            this.flowLayoutPanel2_0.Location = new System.Drawing.Point(460, 3);
            this.flowLayoutPanel2_0.Name = "flowLayoutPanel2_0";
            this.flowLayoutPanel2_0.Size = new System.Drawing.Size(200, 403);
            this.flowLayoutPanel2_0.TabIndex = 1;
            // 
            // btnTakeCheck_0
            // 
            this.btnTakeCheck_0.Enabled = false;
            this.btnTakeCheck_0.Location = new System.Drawing.Point(3, 3);
            this.btnTakeCheck_0.Name = "btnTakeCheck_0";
            this.btnTakeCheck_0.Size = new System.Drawing.Size(194, 32);
            this.btnTakeCheck_0.TabIndex = 0;
            this.btnTakeCheck_0.Text = "Взять чек";
            this.btnTakeCheck_0.UseVisualStyleBackColor = true;
            // 
            // btnTakeCash_0
            // 
            this.btnTakeCash_0.Enabled = false;
            this.btnTakeCash_0.Location = new System.Drawing.Point(3, 41);
            this.btnTakeCash_0.Name = "btnTakeCash_0";
            this.btnTakeCash_0.Size = new System.Drawing.Size(194, 34);
            this.btnTakeCash_0.TabIndex = 3;
            this.btnTakeCash_0.Text = "Взять деньги";
            this.btnTakeCash_0.UseVisualStyleBackColor = true;
            // 
            // gbCard_0
            // 
            this.gbCard_0.Controls.Add(this.btnInsertTakeCard_0);
            this.gbCard_0.Controls.Add(this.rbCardInside_0);
            this.gbCard_0.Location = new System.Drawing.Point(3, 81);
            this.gbCard_0.Name = "gbCard_0";
            this.gbCard_0.Size = new System.Drawing.Size(194, 62);
            this.gbCard_0.TabIndex = 2;
            this.gbCard_0.TabStop = false;
            this.gbCard_0.Text = "Карта";
            // 
            // btnInsertTakeCard_0
            // 
            this.btnInsertTakeCard_0.Location = new System.Drawing.Point(6, 21);
            this.btnInsertTakeCard_0.Name = "btnInsertTakeCard_0";
            this.btnInsertTakeCard_0.Size = new System.Drawing.Size(159, 35);
            this.btnInsertTakeCard_0.TabIndex = 1;
            this.btnInsertTakeCard_0.Text = "Вставить карту";
            this.btnInsertTakeCard_0.UseVisualStyleBackColor = true;
            this.btnInsertTakeCard_0.Click += new System.EventHandler(this.btnInsertTakeCard_0_Click);
            // 
            // rbCardInside_0
            // 
            this.rbCardInside_0.Location = new System.Drawing.Point(171, 30);
            this.rbCardInside_0.Name = "rbCardInside_0";
            this.rbCardInside_0.Size = new System.Drawing.Size(17, 17);
            this.rbCardInside_0.TabIndex = 0;
            this.rbCardInside_0.TabStop = true;
            this.rbCardInside_0.UseVisualStyleBackColor = true;
            // 
            // gbKeyboard_0
            // 
            this.gbKeyboard_0.Controls.Add(this.tbPass_0);
            this.gbKeyboard_0.Controls.Add(this.btnConfirm_0);
            this.gbKeyboard_0.Controls.Add(this.btnCancel_0);
            this.gbKeyboard_0.Location = new System.Drawing.Point(3, 149);
            this.gbKeyboard_0.Name = "gbKeyboard_0";
            this.gbKeyboard_0.Size = new System.Drawing.Size(194, 254);
            this.gbKeyboard_0.TabIndex = 4;
            this.gbKeyboard_0.TabStop = false;
            // 
            // tbPass_0
            // 
            this.tbPass_0.AllowDrop = true;
            this.tbPass_0.Location = new System.Drawing.Point(6, 18);
            this.tbPass_0.Name = "tbPass_0";
            this.tbPass_0.PasswordChar = '*';
            this.tbPass_0.Size = new System.Drawing.Size(167, 25);
            this.tbPass_0.TabIndex = 6;
            // 
            // btnConfirm_0
            // 
            this.btnConfirm_0.Location = new System.Drawing.Point(134, 186);
            this.btnConfirm_0.Name = "btnConfirm_0";
            this.btnConfirm_0.Size = new System.Drawing.Size(58, 49);
            this.btnConfirm_0.TabIndex = 5;
            this.btnConfirm_0.Text = "✓";
            this.btnConfirm_0.UseVisualStyleBackColor = true;
            this.btnConfirm_0.Click += new System.EventHandler(this.btnKeyConfirm_0_Click);
            // 
            // btnCancel_0
            // 
            this.btnCancel_0.Location = new System.Drawing.Point(6, 186);
            this.btnCancel_0.Name = "btnCancel_0";
            this.btnCancel_0.Size = new System.Drawing.Size(58, 49);
            this.btnCancel_0.TabIndex = 3;
            this.btnCancel_0.Text = "✘";
            this.btnCancel_0.UseVisualStyleBackColor = true;
            this.btnCancel_0.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // flowLayoutPanel1_0
            // 
            this.flowLayoutPanel1_0.Controls.Add(this.tbMessage_0);
            this.flowLayoutPanel1_0.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1_0.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1_0.Location = new System.Drawing.Point(8, 3);
            this.flowLayoutPanel1_0.Name = "flowLayoutPanel1_0";
            this.flowLayoutPanel1_0.Size = new System.Drawing.Size(446, 403);
            this.flowLayoutPanel1_0.TabIndex = 0;
            // 
            // tbMessage_0
            // 
            this.tbMessage_0.Location = new System.Drawing.Point(3, 3);
            this.tbMessage_0.Name = "tbMessage_0";
            this.tbMessage_0.Size = new System.Drawing.Size(406, 25);
            this.tbMessage_0.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMainTosaving_0);
            this.groupBox1.Controls.Add(this.btnMainWithdraw_0);
            this.groupBox1.Controls.Add(this.tbMainAmount_0);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbMainBalance_0);
            this.groupBox1.Location = new System.Drawing.Point(3, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 344);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Основной счет";
            // 
            // btnMainTosaving_0
            // 
            this.btnMainTosaving_0.Location = new System.Drawing.Point(99, 210);
            this.btnMainTosaving_0.Name = "btnMainTosaving_0";
            this.btnMainTosaving_0.Size = new System.Drawing.Size(95, 92);
            this.btnMainTosaving_0.TabIndex = 4;
            this.btnMainTosaving_0.Text = "Перевести на накопительный счет";
            this.btnMainTosaving_0.UseVisualStyleBackColor = true;
            // 
            // btnMainWithdraw_0
            // 
            this.btnMainWithdraw_0.Location = new System.Drawing.Point(6, 210);
            this.btnMainWithdraw_0.Name = "btnMainWithdraw_0";
            this.btnMainWithdraw_0.Size = new System.Drawing.Size(87, 92);
            this.btnMainWithdraw_0.TabIndex = 3;
            this.btnMainWithdraw_0.Text = "Снять деньги";
            this.btnMainWithdraw_0.UseVisualStyleBackColor = true;
            this.btnMainWithdraw_0.Click += new System.EventHandler(this.btnMainWithdraw_0_Click);
            // 
            // tbMainAmount_0
            // 
            this.tbMainAmount_0.Location = new System.Drawing.Point(6, 169);
            this.tbMainAmount_0.Name = "tbMainAmount_0";
            this.tbMainAmount_0.Size = new System.Drawing.Size(188, 25);
            this.tbMainAmount_0.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Баланс";
            // 
            // tbMainBalance_0
            // 
            this.tbMainBalance_0.Location = new System.Drawing.Point(6, 75);
            this.tbMainBalance_0.Name = "tbMainBalance_0";
            this.tbMainBalance_0.ReadOnly = true;
            this.tbMainBalance_0.Size = new System.Drawing.Size(188, 25);
            this.tbMainBalance_0.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSavingTomain_0);
            this.groupBox2.Controls.Add(this.btnSavingWithdraw_0);
            this.groupBox2.Controls.Add(this.tbSavingAmount_0);
            this.groupBox2.Controls.Add(this.tbSavingBalance_0);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(209, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 344);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сберегательный счет";
            // 
            // btnSavingTomain_0
            // 
            this.btnSavingTomain_0.Location = new System.Drawing.Point(105, 210);
            this.btnSavingTomain_0.Name = "btnSavingTomain_0";
            this.btnSavingTomain_0.Size = new System.Drawing.Size(95, 92);
            this.btnSavingTomain_0.TabIndex = 6;
            this.btnSavingTomain_0.Text = "Перевести на основной счет";
            this.btnSavingTomain_0.UseVisualStyleBackColor = true;
            // 
            // btnSavingWithdraw_0
            // 
            this.btnSavingWithdraw_0.Location = new System.Drawing.Point(6, 210);
            this.btnSavingWithdraw_0.Name = "btnSavingWithdraw_0";
            this.btnSavingWithdraw_0.Size = new System.Drawing.Size(87, 92);
            this.btnSavingWithdraw_0.TabIndex = 5;
            this.btnSavingWithdraw_0.Text = "Снять деньги";
            this.btnSavingWithdraw_0.UseVisualStyleBackColor = true;
            this.btnSavingWithdraw_0.Click += new System.EventHandler(this.btnSavingWithdraw_0_Click);
            // 
            // tbSavingAmount_0
            // 
            this.tbSavingAmount_0.Location = new System.Drawing.Point(6, 169);
            this.tbSavingAmount_0.Name = "tbSavingAmount_0";
            this.tbSavingAmount_0.Size = new System.Drawing.Size(188, 25);
            this.tbSavingAmount_0.TabIndex = 4;
            // 
            // tbSavingBalance_0
            // 
            this.tbSavingBalance_0.Location = new System.Drawing.Point(6, 75);
            this.tbSavingBalance_0.Name = "tbSavingBalance_0";
            this.tbSavingBalance_0.ReadOnly = true;
            this.tbSavingBalance_0.Size = new System.Drawing.Size(188, 25);
            this.tbSavingBalance_0.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Баланс";
            // 
            // gbCardInfo_0
            // 
            this.gbCardInfo_0.Controls.Add(this.groupBox1_0);
            this.gbCardInfo_0.Controls.Add(this.gbCardNumber_0);
            this.gbCardInfo_0.Location = new System.Drawing.Point(663, 60);
            this.gbCardInfo_0.Name = "gbCardInfo_0";
            this.gbCardInfo_0.Size = new System.Drawing.Size(200, 151);
            this.gbCardInfo_0.TabIndex = 0;
            this.gbCardInfo_0.TabStop = false;
            this.gbCardInfo_0.Text = "Карта";
            // 
            // groupBox1_0
            // 
            this.groupBox1_0.Controls.Add(this.tbCardExpDate_0);
            this.groupBox1_0.Location = new System.Drawing.Point(6, 86);
            this.groupBox1_0.Name = "groupBox1_0";
            this.groupBox1_0.Size = new System.Drawing.Size(131, 60);
            this.groupBox1_0.TabIndex = 1;
            this.groupBox1_0.TabStop = false;
            this.groupBox1_0.Text = "Срок действия";
            // 
            // tbCardExpDate_0
            // 
            this.tbCardExpDate_0.Location = new System.Drawing.Point(6, 24);
            this.tbCardExpDate_0.Mask = "00\\/00";
            this.tbCardExpDate_0.Name = "tbCardExpDate_0";
            this.tbCardExpDate_0.Size = new System.Drawing.Size(47, 25);
            this.tbCardExpDate_0.TabIndex = 0;
            this.tbCardExpDate_0.Text = "1223";
            this.tbCardExpDate_0.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbCardExpDate_1_MaskInputRejected);
            // 
            // gbCardNumber_0
            // 
            this.gbCardNumber_0.Controls.Add(this.tbCardNumber_0);
            this.gbCardNumber_0.Location = new System.Drawing.Point(6, 26);
            this.gbCardNumber_0.Name = "gbCardNumber_0";
            this.gbCardNumber_0.Size = new System.Drawing.Size(188, 56);
            this.gbCardNumber_0.TabIndex = 0;
            this.gbCardNumber_0.TabStop = false;
            this.gbCardNumber_0.Text = "Номер";
            // 
            // tbCardNumber_0
            // 
            this.tbCardNumber_0.Location = new System.Drawing.Point(6, 21);
            this.tbCardNumber_0.Mask = "0000 0000 0000 0000";
            this.tbCardNumber_0.Name = "tbCardNumber_0";
            this.tbCardNumber_0.Size = new System.Drawing.Size(139, 25);
            this.tbCardNumber_0.TabIndex = 2;
            this.tbCardNumber_0.Text = "1111111111111111";
            this.tbCardNumber_0.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbCardNumber_1_MaskInputRejected);
            // 
            // tabPageBankomat2
            // 
            this.tabPageBankomat2.Location = new System.Drawing.Point(4, 26);
            this.tabPageBankomat2.Name = "tabPageBankomat2";
            this.tabPageBankomat2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBankomat2.Size = new System.Drawing.Size(879, 414);
            this.tabPageBankomat2.TabIndex = 1;
            this.tabPageBankomat2.Text = "Банкомат 2";
            this.tabPageBankomat2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 444);
            this.Controls.Add(this.tcBanks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcBanks.ResumeLayout(false);
            this.tabPageBankomat1.ResumeLayout(false);
            this.flowLayoutPanel2_0.ResumeLayout(false);
            this.gbCard_0.ResumeLayout(false);
            this.gbKeyboard_0.ResumeLayout(false);
            this.gbKeyboard_0.PerformLayout();
            this.flowLayoutPanel1_0.ResumeLayout(false);
            this.flowLayoutPanel1_0.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCardInfo_0.ResumeLayout(false);
            this.groupBox1_0.ResumeLayout(false);
            this.groupBox1_0.PerformLayout();
            this.gbCardNumber_0.ResumeLayout(false);
            this.gbCardNumber_0.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCancel_0;
        private System.Windows.Forms.Button btnConfirm_0;
        private System.Windows.Forms.Button btnInsertTakeCard_0;
        private System.Windows.Forms.Button btnMainTosaving_0;
        private System.Windows.Forms.Button btnMainWithdraw_0;
        private System.Windows.Forms.Button btnSavingTomain_0;
        private System.Windows.Forms.Button btnSavingWithdraw_0;
        private System.Windows.Forms.Button btnTakeCash_0;
        private System.Windows.Forms.Button btnTakeCheck_0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1_0;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2_0;
        private System.Windows.Forms.GroupBox gbCard_0;
        private System.Windows.Forms.GroupBox gbCardInfo_0;
        private System.Windows.Forms.GroupBox gbCardNumber_0;
        private System.Windows.Forms.GroupBox gbKeyboard_0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox1_0;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCardInside_0;
        private System.Windows.Forms.TabPage tabPageBankomat1;
        private System.Windows.Forms.TabPage tabPageBankomat2;
        private System.Windows.Forms.MaskedTextBox tbCardExpDate_0;
        private System.Windows.Forms.MaskedTextBox tbCardNumber_0;
        private System.Windows.Forms.TextBox tbMainAmount_0;
        private System.Windows.Forms.TextBox tbMainBalance_0;
        private System.Windows.Forms.TextBox tbMessage_0;
        private System.Windows.Forms.TextBox tbPass_0;
        private System.Windows.Forms.TextBox tbSavingAmount_0;
        private System.Windows.Forms.TextBox tbSavingBalance_0;
        private System.Windows.Forms.TabControl tcBanks;

        #endregion
    }
}