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
                        Accounts = new List<Account>()
                        {
                            new Account()
                            {
                                Balance = 100.0,
                                Card = new Card()
                                {
                                    Blocked = false,
                                    Number = "1111 1111 1111 1111",
                                    ExpDatetime = new DateTime(2023, 11, 1)
                                }
                            }
                        }
                    },
                    new Client()
                    {
                        Id = 2,
                        Fio = "Кек Лол",
                        Accounts = new List<Account>()
                        {
                            new Account()
                            {
                                Balance = 76.0,
                                Card = new Card()
                                {
                                    Blocked = false,
                                    Number = "3456 1111 7436 1111",
                                    ExpDatetime = new DateTime(2027, 11, 1)
                                }
                            },
                            new Account()
                            {
                                Balance = 632
                            }
                        }
                    }
                }
            };
            
            Bank.GetAllCards();
        }

        public void InsertCard(int bankomatNum, string cardNum, string cardExpDate)
        {
            Bank.Bankomats[bankomatNum].InsertCard(cardNum, cardExpDate);
            
            //check card exp
            //find card
            var card = Bank.Cards.FirstOrDefault(x => x.Number == cardNum);
            if (card == null)
            {
                Form.WrongCardMessage();
            }
        }
    }
}