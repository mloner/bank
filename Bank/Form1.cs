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

        
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }
        
        private void btnKeyConfirm_0_Click(object sender, EventArgs e)
        {
            var bankomatNum = 0;
            btnKeyConfirm(bankomatNum);
        }
        
        private void btnKeyConfirm(int bankomatNum)
        {
            if (BankController.IsBankomatInState(bankomatNum, BankomatState.Pincode))
            {
                BankController.CheckPassword(bankomatNum,
                    (Controls.Find($"tbPass_{bankomatNum}", true).First() as TextBox).Text);

            }
        }
        
        // сделать нормальную нумерацию банкоматов блять
        private void btnInsertTakeCard_0_Click(object sender, EventArgs e)
        {
            var bankomatNum = 0;
            btnInsertTakeCard(bankomatNum);
        }
        
        private void btnInsertTakeCard(int bankomatNum)
        {
            if (BankController.Bank.Bankomats[bankomatNum].CurrentCard == null)
            {
                var tbCardNumber = Controls.Find($"tbCardNumber_{bankomatNum}", true).First() as MaskedTextBox;
                var tbCardExpDate = Controls.Find($"tbCardExpDate_{bankomatNum}", true).First() as MaskedTextBox;
            
                BankController.InsertCard(bankomatNum, tbCardNumber.Text, tbCardExpDate.Text);
            }
            else
            {
                BankController.PullCard(0);
            }
            
        }

        private void tbCardNumber_1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void tbCardExpDate_1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        public enum ErrorType
        {
            WrongNumber,
            Expire,
            Blocked,
            WrongPassword
        }
        
        public void ErrorMessage(ErrorType type)
        {
            var textBox = Controls.Find($"tbMessage_0", true).First() as TextBox;
            switch (type)
            {
                case ErrorType.WrongNumber:
                    textBox.Text = "Карты не существует";
                    break;
                case ErrorType.Expire:
                    textBox.Text = "Срок действия карты истек";
                    break;
                case ErrorType.Blocked:
                    textBox.Text = "Эта карта заблокирована и не может быть возвращена";
                    break;
                case ErrorType.WrongPassword:
                    textBox.Text = "Неверный пароль, повторите ввод";
                    
                    break;
            }
            
        }
        
        // сделать нормальную нумерацию банкоматов тоже
        public void CardInserted(int bankomatNum)
        {
            var rb = Controls.Find($"rbCardInside_{bankomatNum}", true).First() as RadioButton;
            rb.Checked = true;
            
            var textBox = Controls.Find($"tbMessage_{bankomatNum}", true).First() as TextBox;
            textBox.Text = "Добро пожаловать в банк. Введите пароль";
            
            var cardButton = Controls.Find($"btnInsertTakeCard_{bankomatNum}", true).First() as Button;
            cardButton.Text = "Извлечь карту";
            cardButton.Enabled = false;
        }
        
        public void WaitComand(int bankomatNum)
        {
            var cardButton = Controls.Find($"btnInsertTakeCard_{bankomatNum}", true).First() as Button;
            cardButton.Enabled = true;

            var tbPass = Controls.Find($"tbPass_{bankomatNum}", true).First() as TextBox;
            tbPass.Clear();
            
            var textBox = Controls.Find($"tbMessage_{bankomatNum}", true).First() as TextBox;
            textBox.Text = "Выберите действие";
        }

        public void CardPulled(int bankomatNum)
        {
            var rb = Controls.Find($"rbCardinside_{bankomatNum}", true).First() as RadioButton;
            rb.Checked = false;
            
            var textBox = Controls.Find($"tbMessage_{bankomatNum}", true).First() as TextBox;
            textBox.Text = "Спасибо за использование банкомата";
            
            var cardButton = Controls.Find($"btnInsertTakeCard_{bankomatNum}", true).First() as Button;
            cardButton.Text = "Вставить карту";
        }
    }
}