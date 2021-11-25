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
        
        private void btnKeyConfirm_Click_1(object sender, EventArgs e)
        {
            var bankomatNum = 0;
            if (BankController.IsBankomatInState(bankomatNum, BankomatState.Pincode))
            {
                BankController.CheckPassword(bankomatNum,
                    (Controls.Find($"tbPass_1", true).First() as TextBox).Text);

            }
        }
        
        // сделать нормальную нумерацию банкоматов блять
        private void btnInsertTakeCard_Click(object sender, EventArgs e)
        {
            if (BankController.Bank.Bankomats[0].CurrentCard == null)
            {
                var tbCardNumber = Controls.Find($"tbCardNumber_1", true).First() as MaskedTextBox;
                var tbCardExpDate = Controls.Find($"tbCardExpDate_1", true).First() as MaskedTextBox;
            
                BankController.InsertCard(0, tbCardNumber.Text, tbCardExpDate.Text);
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
            var textBox = Controls.Find($"textBox1", true).First() as TextBox;
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
        public void CardInserted()
        {
            var rb = Controls.Find($"cardinside_1", true).First() as RadioButton;

            var textBox = Controls.Find($"textBox1", true).First() as TextBox;
            
            var cardButton = Controls.Find($"btnInsertTakeCard_1", true).First() as Button;

            cardButton.Text = "Извлечь карту";
            cardButton.Enabled = false;
            textBox.Text = "Добро пожаловать в банк. Введите пароль";
            rb.Checked = true;
        }
        
        public void WaitComand()
        {
            var cardButton = Controls.Find($"btnInsertTakeCard_1", true).First() as Button;
            cardButton.Enabled = true;

            var tbPass = Controls.Find($"tbPass_1", true).First() as TextBox;
            tbPass.Clear();
            
            var textBox = Controls.Find($"textBox1", true).First() as TextBox;
            textBox.Text = "Выберите действие";
        }

        public void CardPulled()
        {
            var rb = Controls.Find($"cardinside_1", true).First() as RadioButton;
            var textBox = Controls.Find($"textBox1", true).First() as TextBox;

            var cardButton = Controls.Find($"btnInsertTakeCard_1", true).First() as Button;

            cardButton.Text = "Вставить карту";
            textBox.Text = "Спасибо за использование банкомата";
            rb.Checked = false;
        }

       // public void 
        
    }
}