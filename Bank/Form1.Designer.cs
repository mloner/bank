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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTakeCheck = new System.Windows.Forms.Button();
            this.btnTakeCash = new System.Windows.Forms.Button();
            this.gbCard = new System.Windows.Forms.GroupBox();
            this.btnInsertTakeCard_1 = new System.Windows.Forms.Button();
            this.cardinside_1 = new System.Windows.Forms.RadioButton();
            this.gbKeyboard = new System.Windows.Forms.GroupBox();
            this.tbPass_1 = new System.Windows.Forms.TextBox();
            this.btnKeyConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbCardInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCardExpDate_1 = new System.Windows.Forms.MaskedTextBox();
            this.gbCardNumber = new System.Windows.Forms.GroupBox();
            this.tbCardNumber_1 = new System.Windows.Forms.MaskedTextBox();
            this.tabPageBankomat2 = new System.Windows.Forms.TabPage();
            this.tcBanks.SuspendLayout();
            this.tabPageBankomat1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbCard.SuspendLayout();
            this.gbKeyboard.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.gbCardInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCardNumber.SuspendLayout();
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
            this.tabPageBankomat1.Controls.Add(this.flowLayoutPanel2);
            this.tabPageBankomat1.Controls.Add(this.flowLayoutPanel1);
            this.tabPageBankomat1.Controls.Add(this.gbCardInfo);
            this.tabPageBankomat1.Location = new System.Drawing.Point(4, 26);
            this.tabPageBankomat1.Name = "tabPageBankomat1";
            this.tabPageBankomat1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBankomat1.Size = new System.Drawing.Size(879, 414);
            this.tabPageBankomat1.TabIndex = 0;
            this.tabPageBankomat1.Text = "Банкомат 1";
            this.tabPageBankomat1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnTakeCheck);
            this.flowLayoutPanel2.Controls.Add(this.btnTakeCash);
            this.flowLayoutPanel2.Controls.Add(this.gbCard);
            this.flowLayoutPanel2.Controls.Add(this.gbKeyboard);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(460, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 403);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnTakeCheck
            // 
            this.btnTakeCheck.Enabled = false;
            this.btnTakeCheck.Location = new System.Drawing.Point(3, 3);
            this.btnTakeCheck.Name = "btnTakeCheck";
            this.btnTakeCheck.Size = new System.Drawing.Size(194, 32);
            this.btnTakeCheck.TabIndex = 0;
            this.btnTakeCheck.Text = "Взять чек";
            this.btnTakeCheck.UseVisualStyleBackColor = true;
            // 
            // btnTakeCash
            // 
            this.btnTakeCash.Enabled = false;
            this.btnTakeCash.Location = new System.Drawing.Point(3, 41);
            this.btnTakeCash.Name = "btnTakeCash";
            this.btnTakeCash.Size = new System.Drawing.Size(194, 34);
            this.btnTakeCash.TabIndex = 3;
            this.btnTakeCash.Text = "Взять деньги";
            this.btnTakeCash.UseVisualStyleBackColor = true;
            // 
            // gbCard
            // 
            this.gbCard.Controls.Add(this.btnInsertTakeCard_1);
            this.gbCard.Controls.Add(this.cardinside_1);
            this.gbCard.Location = new System.Drawing.Point(3, 81);
            this.gbCard.Name = "gbCard";
            this.gbCard.Size = new System.Drawing.Size(194, 62);
            this.gbCard.TabIndex = 2;
            this.gbCard.TabStop = false;
            this.gbCard.Text = "Карта";
            // 
            // btnInsertTakeCard_1
            // 
            this.btnInsertTakeCard_1.Location = new System.Drawing.Point(6, 21);
            this.btnInsertTakeCard_1.Name = "btnInsertTakeCard_1";
            this.btnInsertTakeCard_1.Size = new System.Drawing.Size(159, 35);
            this.btnInsertTakeCard_1.TabIndex = 1;
            this.btnInsertTakeCard_1.Text = "Вставить карту";
            this.btnInsertTakeCard_1.UseVisualStyleBackColor = true;
            this.btnInsertTakeCard_1.Click += new System.EventHandler(this.btnInsertTakeCard_Click);
            // 
            // cardinside_1
            // 
            this.cardinside_1.Location = new System.Drawing.Point(171, 30);
            this.cardinside_1.Name = "cardinside_1";
            this.cardinside_1.Size = new System.Drawing.Size(17, 17);
            this.cardinside_1.TabIndex = 0;
            this.cardinside_1.TabStop = true;
            this.cardinside_1.UseVisualStyleBackColor = true;
            // 
            // gbKeyboard
            // 
            this.gbKeyboard.Controls.Add(this.tbPass_1);
            this.gbKeyboard.Controls.Add(this.btnKeyConfirm);
            this.gbKeyboard.Controls.Add(this.btnCancel);
            this.gbKeyboard.Location = new System.Drawing.Point(3, 149);
            this.gbKeyboard.Name = "gbKeyboard";
            this.gbKeyboard.Size = new System.Drawing.Size(194, 254);
            this.gbKeyboard.TabIndex = 4;
            this.gbKeyboard.TabStop = false;
            // 
            // tbPass_1
            // 
            this.tbPass_1.AllowDrop = true;
            this.tbPass_1.Location = new System.Drawing.Point(6, 18);
            this.tbPass_1.Name = "tbPass_1";
            this.tbPass_1.PasswordChar = '*';
            this.tbPass_1.Size = new System.Drawing.Size(167, 25);
            this.tbPass_1.TabIndex = 6;
            // 
            // btnKeyConfirm
            // 
            this.btnKeyConfirm.Location = new System.Drawing.Point(134, 186);
            this.btnKeyConfirm.Name = "btnKeyConfirm";
            this.btnKeyConfirm.Size = new System.Drawing.Size(58, 49);
            this.btnKeyConfirm.TabIndex = 5;
            this.btnKeyConfirm.Text = "✓";
            this.btnKeyConfirm.UseVisualStyleBackColor = true;
            this.btnKeyConfirm.Click += new System.EventHandler(this.btnKeyConfirm_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(6, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(58, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "✘";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(446, 403);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 25);
            this.textBox1.TabIndex = 0;
            // 
            // gbCardInfo
            // 
            this.gbCardInfo.Controls.Add(this.groupBox1);
            this.gbCardInfo.Controls.Add(this.gbCardNumber);
            this.gbCardInfo.Location = new System.Drawing.Point(663, 60);
            this.gbCardInfo.Name = "gbCardInfo";
            this.gbCardInfo.Size = new System.Drawing.Size(200, 151);
            this.gbCardInfo.TabIndex = 0;
            this.gbCardInfo.TabStop = false;
            this.gbCardInfo.Text = "Карта";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCardExpDate_1);
            this.groupBox1.Location = new System.Drawing.Point(6, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Срок действия";
            // 
            // tbCardExpDate_1
            // 
            this.tbCardExpDate_1.Location = new System.Drawing.Point(6, 24);
            this.tbCardExpDate_1.Mask = "00\\/00";
            this.tbCardExpDate_1.Name = "tbCardExpDate_1";
            this.tbCardExpDate_1.Size = new System.Drawing.Size(47, 25);
            this.tbCardExpDate_1.TabIndex = 0;
            this.tbCardExpDate_1.Text = "1223";
            this.tbCardExpDate_1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbCardExpDate_1_MaskInputRejected);
            // 
            // gbCardNumber
            // 
            this.gbCardNumber.Controls.Add(this.tbCardNumber_1);
            this.gbCardNumber.Location = new System.Drawing.Point(6, 26);
            this.gbCardNumber.Name = "gbCardNumber";
            this.gbCardNumber.Size = new System.Drawing.Size(188, 56);
            this.gbCardNumber.TabIndex = 0;
            this.gbCardNumber.TabStop = false;
            this.gbCardNumber.Text = "Номер";
            // 
            // tbCardNumber_1
            // 
            this.tbCardNumber_1.Location = new System.Drawing.Point(6, 21);
            this.tbCardNumber_1.Mask = "0000 0000 0000 0000";
            this.tbCardNumber_1.Name = "tbCardNumber_1";
            this.tbCardNumber_1.Size = new System.Drawing.Size(139, 25);
            this.tbCardNumber_1.TabIndex = 2;
            this.tbCardNumber_1.Text = "1111111111111111";
            this.tbCardNumber_1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbCardNumber_1_MaskInputRejected);
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
            this.flowLayoutPanel2.ResumeLayout(false);
            this.gbCard.ResumeLayout(false);
            this.gbKeyboard.ResumeLayout(false);
            this.gbKeyboard.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.gbCardInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCardNumber.ResumeLayout(false);
            this.gbCardNumber.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox tbPass_1;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsertTakeCard_1;
        private System.Windows.Forms.Button btnKeyConfirm;
        private System.Windows.Forms.Button btnTakeCash;
        private System.Windows.Forms.Button btnTakeCheck;
        private System.Windows.Forms.RadioButton cardinside_1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox gbCard;
        private System.Windows.Forms.GroupBox gbCardInfo;
        private System.Windows.Forms.GroupBox gbCardNumber;
        private System.Windows.Forms.GroupBox gbKeyboard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPageBankomat1;
        private System.Windows.Forms.TabPage tabPageBankomat2;
        private System.Windows.Forms.MaskedTextBox tbCardExpDate_1;
        private System.Windows.Forms.MaskedTextBox tbCardNumber_1;
        private System.Windows.Forms.TabControl tcBanks;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.MaskedTextBox tbCardNumber;
        private System.Windows.Forms.MaskedTextBox tbCardExpDate;

        #endregion

        private System.Windows.Forms.TabControl tcBank1;
    }
}