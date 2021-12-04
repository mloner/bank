using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        
        
        public void ErrorMessage(ErrorType type, object param = null)
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
                    switch ((int)param)
                    {
                        case 2:
                            textBox.Text = "Неверный пароль, осталось 2 попытки";
                            break;
                        case 1:
                            textBox.Text = "Неверный пароль, осталось 1 попытка";
                            break;
                        case 0:
                            textBox.Text = "Неверный пароль, карта заблокирована";
                            break;
                    }
                    break;
                case ErrorType.NotEnoughAccountMoney:
                    textBox.Text = "Недостаточно денег на счету, введите другую сумму";
                    break;
                case ErrorType.NotEnoughBankomatMoney:
                    textBox.Text = "Недостаточно купюр в банкомате, введите другую сумму";
                    break;
                case ErrorType.LimitIsReached:
                    textBox.Text = $"Суточный лимит превышен на {(double)param} руб.";
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
            
            var accounts =  BankController.GetAccountsByCardNum(BankController.Bank.Bankomats[bankomatNum].CurrentCard.Number);

            var mainAcc = accounts[0];
            var savAcc = accounts[1];
            
            //update balances
            //main acc
            var tbMainBalance = Controls.Find($"tbMainBalance_{bankomatNum}", true).First() as TextBox;
            tbMainBalance.Text = $"{mainAcc.Balance.ToString(CultureInfo.InvariantCulture)} руб.";
            //sav acc
            var tbSavingBalance = Controls.Find($"tbSavingBalance_{bankomatNum}", true).First() as TextBox;
            tbSavingBalance.Text = $"{savAcc.Balance.ToString(CultureInfo.InvariantCulture)} руб.";
            
            
            
            //clear accounts
            //main
            var mainAmount = Controls.Find($"tbMainAmount_{bankomatNum}", true).First() as TextBox;
            mainAmount.Clear();
            //sav
            var savAmount = Controls.Find($"tbSavingAmount_{bankomatNum}", true).First() as TextBox;
            savAmount.Clear();
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
        
        public void CardBlocked(int bankomatNum)
        {
            var rb = Controls.Find($"rbCardinside_{bankomatNum}", true).First() as RadioButton;
            rb.Checked = false;

            var cardButton = Controls.Find($"btnInsertTakeCard_{bankomatNum}", true).First() as Button;
            cardButton.Text = "Вставить карту";
            cardButton.Enabled = true;
            
        }
        

        private void btnMainWithdraw_0_Click(object sender, EventArgs e)
        {
            var bankomatNum = 0;
            var tbAmount = Controls.Find($"tbMainAmount_{bankomatNum}", true).First() as TextBox;
            WithdrawMoney(bankomatNum, AccountType.Main, tbAmount);
        }

        private void btnSavingWithdraw_0_Click(object sender, EventArgs e)
        {
            var bankomatNum = 0;
            var tbAmount = Controls.Find($"tbSavingAmount_{bankomatNum}", true).First() as TextBox;
            WithdrawMoney(bankomatNum, AccountType.Saving, tbAmount);
        }

        private void WithdrawMoney(int bankomatNum, AccountType accountType, TextBox textBox)
        {
            var amount = textBox.Text == "" ? 0 : double.Parse(textBox.Text);
            BankController.WithdrawMoney(bankomatNum, accountType, amount);
        }

        private void btnMainTosaving_0_Click(object sender, EventArgs e)
        {
            AccountType accountType = AccountType.Main;
            int bankomatNum = 0;
            var tbAmount = Controls.Find($"tbMainAmount_{bankomatNum}", true).First() as TextBox;
            var amount = tbAmount.Text == "" ? 0 : double.Parse(tbAmount.Text);
            BankController.TransitMoney(bankomatNum, accountType, amount);
        }


        private void btnSavingTomain_0_Click(object sender, EventArgs e)
        {
            AccountType accountType = AccountType.Saving;
            int bankomatNum = 0;
            var tbAmount = Controls.Find($"tbSavingAmount_{bankomatNum}", true).First() as TextBox;
            var amount = tbAmount.Text == "" ? 0 : double.Parse(tbAmount.Text);
            BankController.TransitMoney(bankomatNum, accountType, amount);
        }
    }
}