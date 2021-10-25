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
            this.btnInsertTakeCard = new System.Windows.Forms.Button();
            this.cardinside = new System.Windows.Forms.RadioButton();
            this.gbKeyboard = new System.Windows.Forms.GroupBox();
            this.btnKeyConfirm = new System.Windows.Forms.Button();
            this.btnKey9 = new System.Windows.Forms.Button();
            this.btnKey0 = new System.Windows.Forms.Button();
            this.btnKey8 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnKey7 = new System.Windows.Forms.Button();
            this.btnKey6 = new System.Windows.Forms.Button();
            this.btnKey5 = new System.Windows.Forms.Button();
            this.btnKey4 = new System.Windows.Forms.Button();
            this.btnKey3 = new System.Windows.Forms.Button();
            this.btnKey2 = new System.Windows.Forms.Button();
            this.btnKey1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gbCardInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbCardNumber = new System.Windows.Forms.GroupBox();
            this.tabPageBankomat2 = new System.Windows.Forms.TabPage();
            this.tbCardNumber = new System.Windows.Forms.MaskedTextBox();
            this.tbCardExpDate = new System.Windows.Forms.MaskedTextBox();
            this.tcBanks.SuspendLayout();
            this.tabPageBankomat1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.gbCard.SuspendLayout();
            this.gbKeyboard.SuspendLayout();
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
            this.gbCard.Controls.Add(this.btnInsertTakeCard);
            this.gbCard.Controls.Add(this.cardinside);
            this.gbCard.Location = new System.Drawing.Point(3, 81);
            this.gbCard.Name = "gbCard";
            this.gbCard.Size = new System.Drawing.Size(194, 62);
            this.gbCard.TabIndex = 2;
            this.gbCard.TabStop = false;
            this.gbCard.Text = "Карта";
            // 
            // btnInsertTakeCard
            // 
            this.btnInsertTakeCard.Location = new System.Drawing.Point(6, 21);
            this.btnInsertTakeCard.Name = "btnInsertTakeCard";
            this.btnInsertTakeCard.Size = new System.Drawing.Size(159, 35);
            this.btnInsertTakeCard.TabIndex = 1;
            this.btnInsertTakeCard.Text = "Вставить карту";
            this.btnInsertTakeCard.UseVisualStyleBackColor = true;
            // 
            // cardinside
            // 
            this.cardinside.Location = new System.Drawing.Point(171, 30);
            this.cardinside.Name = "cardinside";
            this.cardinside.Size = new System.Drawing.Size(17, 17);
            this.cardinside.TabIndex = 0;
            this.cardinside.TabStop = true;
            this.cardinside.UseVisualStyleBackColor = true;
            // 
            // gbKeyboard
            // 
            this.gbKeyboard.Controls.Add(this.btnKeyConfirm);
            this.gbKeyboard.Controls.Add(this.btnKey9);
            this.gbKeyboard.Controls.Add(this.btnKey0);
            this.gbKeyboard.Controls.Add(this.btnKey8);
            this.gbKeyboard.Controls.Add(this.btnCancel);
            this.gbKeyboard.Controls.Add(this.btnKey7);
            this.gbKeyboard.Controls.Add(this.btnKey6);
            this.gbKeyboard.Controls.Add(this.btnKey5);
            this.gbKeyboard.Controls.Add(this.btnKey4);
            this.gbKeyboard.Controls.Add(this.btnKey3);
            this.gbKeyboard.Controls.Add(this.btnKey2);
            this.gbKeyboard.Controls.Add(this.btnKey1);
            this.gbKeyboard.Location = new System.Drawing.Point(3, 149);
            this.gbKeyboard.Name = "gbKeyboard";
            this.gbKeyboard.Size = new System.Drawing.Size(194, 254);
            this.gbKeyboard.TabIndex = 4;
            this.gbKeyboard.TabStop = false;
            // 
            // btnKeyConfirm
            // 
            this.btnKeyConfirm.Location = new System.Drawing.Point(134, 186);
            this.btnKeyConfirm.Name = "btnKeyConfirm";
            this.btnKeyConfirm.Size = new System.Drawing.Size(58, 49);
            this.btnKeyConfirm.TabIndex = 5;
            this.btnKeyConfirm.Text = "✓";
            this.btnKeyConfirm.UseVisualStyleBackColor = true;
            this.btnKeyConfirm.Click += new System.EventHandler(this.btnKeyConfirm_Click);
            // 
            // btnKey9
            // 
            this.btnKey9.Location = new System.Drawing.Point(134, 131);
            this.btnKey9.Name = "btnKey9";
            this.btnKey9.Size = new System.Drawing.Size(58, 49);
            this.btnKey9.TabIndex = 8;
            this.btnKey9.Text = "9";
            this.btnKey9.UseVisualStyleBackColor = true;
            this.btnKey9.Click += new System.EventHandler(this.btnKey9_Click);
            // 
            // btnKey0
            // 
            this.btnKey0.Location = new System.Drawing.Point(70, 186);
            this.btnKey0.Name = "btnKey0";
            this.btnKey0.Size = new System.Drawing.Size(58, 49);
            this.btnKey0.TabIndex = 4;
            this.btnKey0.Text = "0";
            this.btnKey0.UseVisualStyleBackColor = true;
            this.btnKey0.Click += new System.EventHandler(this.btnKey0_Click);
            // 
            // btnKey8
            // 
            this.btnKey8.Location = new System.Drawing.Point(70, 131);
            this.btnKey8.Name = "btnKey8";
            this.btnKey8.Size = new System.Drawing.Size(58, 49);
            this.btnKey8.TabIndex = 7;
            this.btnKey8.Text = "8";
            this.btnKey8.UseVisualStyleBackColor = true;
            this.btnKey8.Click += new System.EventHandler(this.btnKey8_Click);
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
            // btnKey7
            // 
            this.btnKey7.Location = new System.Drawing.Point(6, 131);
            this.btnKey7.Name = "btnKey7";
            this.btnKey7.Size = new System.Drawing.Size(58, 49);
            this.btnKey7.TabIndex = 6;
            this.btnKey7.Text = "7";
            this.btnKey7.UseVisualStyleBackColor = true;
            this.btnKey7.Click += new System.EventHandler(this.btnKey7_Click);
            // 
            // btnKey6
            // 
            this.btnKey6.Location = new System.Drawing.Point(134, 76);
            this.btnKey6.Name = "btnKey6";
            this.btnKey6.Size = new System.Drawing.Size(58, 49);
            this.btnKey6.TabIndex = 5;
            this.btnKey6.Text = "6";
            this.btnKey6.UseVisualStyleBackColor = true;
            this.btnKey6.Click += new System.EventHandler(this.btnKey6_Click);
            // 
            // btnKey5
            // 
            this.btnKey5.Location = new System.Drawing.Point(70, 76);
            this.btnKey5.Name = "btnKey5";
            this.btnKey5.Size = new System.Drawing.Size(58, 49);
            this.btnKey5.TabIndex = 4;
            this.btnKey5.Text = "5";
            this.btnKey5.UseVisualStyleBackColor = true;
            this.btnKey5.Click += new System.EventHandler(this.btnKey5_Click);
            // 
            // btnKey4
            // 
            this.btnKey4.Location = new System.Drawing.Point(6, 76);
            this.btnKey4.Name = "btnKey4";
            this.btnKey4.Size = new System.Drawing.Size(58, 49);
            this.btnKey4.TabIndex = 3;
            this.btnKey4.Text = "4";
            this.btnKey4.UseVisualStyleBackColor = true;
            this.btnKey4.Click += new System.EventHandler(this.btnKey4_Click);
            // 
            // btnKey3
            // 
            this.btnKey3.Location = new System.Drawing.Point(134, 21);
            this.btnKey3.Name = "btnKey3";
            this.btnKey3.Size = new System.Drawing.Size(58, 49);
            this.btnKey3.TabIndex = 2;
            this.btnKey3.Text = "3";
            this.btnKey3.UseVisualStyleBackColor = true;
            this.btnKey3.Click += new System.EventHandler(this.btnKey3_Click);
            // 
            // btnKey2
            // 
            this.btnKey2.Location = new System.Drawing.Point(70, 21);
            this.btnKey2.Name = "btnKey2";
            this.btnKey2.Size = new System.Drawing.Size(58, 49);
            this.btnKey2.TabIndex = 1;
            this.btnKey2.Text = "2";
            this.btnKey2.UseVisualStyleBackColor = true;
            this.btnKey2.Click += new System.EventHandler(this.btnKey2_Click);
            // 
            // btnKey1
            // 
            this.btnKey1.Location = new System.Drawing.Point(6, 21);
            this.btnKey1.Name = "btnKey1";
            this.btnKey1.Size = new System.Drawing.Size(58, 49);
            this.btnKey1.TabIndex = 0;
            this.btnKey1.Text = "1";
            this.btnKey1.UseVisualStyleBackColor = true;
            this.btnKey1.Click += new System.EventHandler(this.btnKey1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(446, 403);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gbCardInfo
            // 
            this.gbCardInfo.Controls.Add(this.groupBox1);
            this.gbCardInfo.Controls.Add(this.gbCardNumber);
            this.gbCardInfo.Location = new System.Drawing.Point(663, 59);
            this.gbCardInfo.Name = "gbCardInfo";
            this.gbCardInfo.Size = new System.Drawing.Size(200, 151);
            this.gbCardInfo.TabIndex = 0;
            this.gbCardInfo.TabStop = false;
            this.gbCardInfo.Text = "Карта";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCardExpDate);
            this.groupBox1.Location = new System.Drawing.Point(6, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Срок действия";
            // 
            // gbCardNumber
            // 
            this.gbCardNumber.Controls.Add(this.tbCardNumber);
            this.gbCardNumber.Location = new System.Drawing.Point(6, 25);
            this.gbCardNumber.Name = "gbCardNumber";
            this.gbCardNumber.Size = new System.Drawing.Size(188, 56);
            this.gbCardNumber.TabIndex = 0;
            this.gbCardNumber.TabStop = false;
            this.gbCardNumber.Text = "Номер";
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
            // tbCardNumber
            // 
            this.tbCardNumber.Location = new System.Drawing.Point(6, 21);
            this.tbCardNumber.Mask = "0000 0000 0000 0000";
            this.tbCardNumber.Name = "tbCardNumber";
            this.tbCardNumber.Size = new System.Drawing.Size(139, 25);
            this.tbCardNumber.TabIndex = 2;
            // 
            // tbCardExpDate
            // 
            this.tbCardExpDate.Location = new System.Drawing.Point(6, 24);
            this.tbCardExpDate.Mask = "00\\/00";
            this.tbCardExpDate.Name = "tbCardExpDate";
            this.tbCardExpDate.Size = new System.Drawing.Size(47, 25);
            this.tbCardExpDate.TabIndex = 0;
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
            this.gbCardInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCardNumber.ResumeLayout(false);
            this.gbCardNumber.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;

        private System.Windows.Forms.Button btnKeyConfirm;

        private System.Windows.Forms.Button btnKey0;

        private System.Windows.Forms.Button btnCancel;

        private System.Windows.Forms.Button btnKey6;

        private System.Windows.Forms.Button btnKey5;

        private System.Windows.Forms.Button btnKey4;

        private System.Windows.Forms.Button btnKey9;

        private System.Windows.Forms.Button btnKey7;

        private System.Windows.Forms.Button btnKey8;

        private System.Windows.Forms.Button btnKey2;

        private System.Windows.Forms.Button btnKey3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btnKey1;

        private System.Windows.Forms.GroupBox gbKeyboard;

        private System.Windows.Forms.MaskedTextBox tbCardNumber;
        private System.Windows.Forms.GroupBox gbCardNumber;
        private System.Windows.Forms.MaskedTextBox tbCardExpDate;

        private System.Windows.Forms.GroupBox gbCardInfo;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.RadioButton cardinside;
        private System.Windows.Forms.Button btnTakeCheck;
        private System.Windows.Forms.Button btnTakeCash;
        private System.Windows.Forms.Button btnInsertTakeCard;

        private System.Windows.Forms.GroupBox gbCard;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

        private System.Windows.Forms.TabControl tcBanks;

        #endregion

        private System.Windows.Forms.TabControl tcBank1;
        private System.Windows.Forms.TabPage tabPageBankomat1;
        private System.Windows.Forms.TabPage tabPageBankomat2;
    }
}