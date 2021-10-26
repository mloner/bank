using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Controller;
using Bank.Models;

namespace Bank
{
    public partial class Form1 : Form
    {
        public BankController BankController { get; set; }
        public Form1()
        {
            InitializeComponent();
            
            BankController = new BankController(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey8_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey7_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey9_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey4_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey2_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey3_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey5_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey6_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKey0_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnKeyConfirm_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void btnInsertTakeCard_Click(object sender, EventArgs e)
        {
            var tbCardNumber = Controls.Find($"tbCardNumber_1", true).First() as MaskedTextBox;
            var tbCardExpDate = Controls.Find($"tbCardExpDate_1", true).First() as MaskedTextBox;
            
            BankController.InsertCard(1 , tbCardNumber.Text, tbCardExpDate.Text);
        }

        private void tbCardNumber_1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void tbCardExpDate_1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        public void WrongCardMessage()
        {
            var textBox = Controls.Find($"textBox1", true).First() as TextBox;

            textBox.Text = "Карты не существует";
        }
    }
}