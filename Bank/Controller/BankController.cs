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
                    new Bankomat(),
                    new Bankomat()
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

        private bool CheckExp(Card card)
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
            var currentBank = Bank.Bankomats[bankomatNum];
            //var insertedCard = currentBank.InsertCard(cardNum, cardExpDate);
            var correct = false;
            
            //check card exp
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
                    if (CheckExp(card))
                    {
                        currentBank.CurrentCard = card; 
                        Form.CardInserted();
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
    }
}