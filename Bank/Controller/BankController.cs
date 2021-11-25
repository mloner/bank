using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bank.Models;

namespace Bank.Controller
{
    public class BankController
    {
        public Models.Bank Bank { get; set; }
        public Form1 Form { get; set; }

        public BankController(Form1 form)
        {
            Form = form;
            Bank = new Models.Bank()
            {
                Bankomats = new List<Bankomat>()
                {
                    new Bankomat()
                    {
                        Id = 0,
                    },
                    new Bankomat()
                    {
                        Id = 1
                    }
                },
                Clients = new List<Client>()
                {
                    new Client()
                    {
                        Id = 1,
                        Fio = "Дудка Трубник",
                        Card = new Card()
                        {
                            Blocked = false,
                            Number = "1111 1111 1111 1111",
                            ExpDatetime = new DateTime(2023, 11, 1),
                            Pin = "1234"
                        },
                        Accounts = new List<Account>()
                        {
                            new Account()
                            {
                                Balance = 100.0,
                                Type = AccountType.Main
                            },
                            new Account()
                            {
                                Balance = 70.0,
                                Type = AccountType.Saving
                            }
                        }
                    },
                    new Client()
                    {
                        Id = 2,
                        Fio = "Кек Лол",
                        Card = new Card()
                        {
                            Blocked = false,
                            Number = "3456 1111 7436 1111",
                            ExpDatetime = new DateTime(2027, 11, 1),
                            Pin = "5312"
                        },
                        Accounts = new List<Account>()
                        {
                            new Account()
                            {
                                Balance = 76.0,
                                Type = AccountType.Main
                            },
                            new Account()
                            {
                                Balance = 632,
                                Type = AccountType.Saving
                            }
                        }
                    }
                }
            };
            
            Bank.GetAllCards();
        }

        private bool IsCardValidDateExp(Card card)
        {
            DateTime now = DateTime.Now;
            if (now.CompareTo(card.ExpDatetime) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public void InsertCard(int bankomatNum, string cardNum, string cardExpDate)
        {
            var currentBankomat = Bank.Bankomats[bankomatNum];
            
            //find card
            var card = Bank.Cards.FirstOrDefault(x => x.Number == cardNum);
            
            if (card == null)
            {
                Form.ErrorMessage(Form1.ErrorType.WrongNumber);
            }
            else
            {
                if (!card.Blocked)
                {
                    if (IsCardValidDateExp(card))
                    {
                        currentBankomat.CurrentCard = card;
                        Form.CardInserted(currentBankomat.Id);
                        currentBankomat.State = BankomatState.Pincode; //waiting for pincode
                    }
                    else
                    {
                        Form.ErrorMessage(Form1.ErrorType.Expire);
                    }
                }
                else
                {
                    Form.ErrorMessage(Form1.ErrorType.Blocked);
                }
            }
        }

        public void CheckPassword(int bankomatNum, string pass)
        {
            var bankomat = Bank.Bankomats[bankomatNum];
            if (bankomat.CurrentCard.Pin == pass)
            {
                bankomat.State = BankomatState.WaitCommand;
                Form.WaitComand(bankomat.Id);
            }
            else
            {
                Form.ErrorMessage(Form1.ErrorType.WrongPassword);
                //Form.
            }
        }
        
        public void PullCard(int bankomatNum)
        {
            var currentBankomat = Bank.Bankomats[bankomatNum];
            currentBankomat.CurrentCard = null;
            Form.CardPulled(currentBankomat.Id);
        }
        
        public bool IsBankomatInState(int bankomanNum, BankomatState state)
        {
            return this.Bank.Bankomats[bankomanNum].State == state;
        }
        
    }
}