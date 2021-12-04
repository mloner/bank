using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Bank.Models;
using Bank.Models.Bankomat;

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
                                Balance = 1_000_000.0,
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
                Form.ErrorMessage(ErrorType.WrongNumber);
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
                        Form.ErrorMessage(ErrorType.Expire);
                    }
                }
                else
                {
                    Form.ErrorMessage(ErrorType.Blocked);
                }
            }
        }

        public void CheckPassword(int bankomatNum, string pass)
        {
            var bankomat = Bank.Bankomats[bankomatNum];
            if (bankomat.CurrentCard.Pin == pass && bankomat.CurrentCard.Attempts != 0)
            {
                bankomat.State = BankomatState.WaitCommand;
                bankomat.CurrentCard.Attempts = 3;
                Form.WaitComand(bankomat.Id);
            }
            else
            {
                bankomat.CurrentCard.Attempts -= 1;
                // если кончились попытки карта блокируется
                if (bankomat.CurrentCard.Attempts == 0)
                {
                    bankomat.CurrentCard.Blocked = true;
                    Bank.Bankomats[bankomatNum].State = BankomatState.NoCard;
                    
                    Form.ErrorMessage(ErrorType.WrongPassword, bankomat.CurrentCard.Attempts); 
                    Bank.Bankomats[bankomatNum].CurrentCard = null;
                    Form.CardBlocked(bankomat.Id);
                }
                else
                {
                    Form.ErrorMessage(ErrorType.WrongPassword, bankomat.CurrentCard.Attempts); 
                }
                
                
            }

            
        }

        public void PullCard(int bankomatNum)
        {
            var currentBankomat = Bank.Bankomats[bankomatNum];
            currentBankomat.CurrentCard = null;
            Bank.Bankomats[bankomatNum].State = BankomatState.NoCard;
            Form.CardPulled(currentBankomat.Id);
        }
        
        public bool IsBankomatInState(int bankomanNum, BankomatState state)
        {
            return this.Bank.Bankomats[bankomanNum].State == state;
        }

        public List<Account> GetAccountsByCardNum(string cardNum)
        {
            return GetAccountsByClient(GetClientByCardNum(cardNum));
        }

        public List<Account> GetAccountsByClient(Client client)
        {
            return client.Accounts;
        }

        public Client GetClientByCardNum(string cardNum)
        {
            return this.Bank.Clients.First(x => x.Card.Number == cardNum);
        }

        public void WithdrawMoney(int bankomanNum, AccountType accountType, double amount)
        {
            var card = this.Bank.Bankomats[bankomanNum].CurrentCard;
            var client = GetClientByCardNum(card.Number);
            var accounts = GetAccountsByCardNum(card.Number);
            var acc = accounts.First(x => x.Type == accountType);
            
            //пытаемся снять
            if(client.DayLimit < amount) // суточный лимит клеинта исчерпан
            {
                Form.WaitComand(bankomanNum);
                Form.ErrorMessage(ErrorType.LimitIsReached, amount - client.DayLimit);
            }
            else if (acc.Balance < amount) // не хватает денег на балансе счета
            {
                Form.WaitComand(bankomanNum);
                Form.ErrorMessage(ErrorType.NotEnoughAccountMoney);
            }
            // else if(Bank.Bankomats[bankomanNum].Balance < amount) // не хватает денег на балансе банкомата
            // {
            //     Form.WaitComand(bankomanNum);
            //     Form.ErrorMessage(ErrorType.NotEnoughBankomatMoney);
            // }
            else
            {
                var dict = TryWithdraw(amount, bankomanNum);
                if (dict.Count <= 0)
                {
                    Form.WaitComand(bankomanNum);
                    Form.ErrorMessage(ErrorType.NotEnoughBankomatMoney);
                }
                else
                {
                    acc.Balance -= amount;
                    client.DayLimit -= amount;
                    
                    Bankomat bankomat = this.Bank.Bankomats[bankomanNum];
                    foreach (var keyValuePair in dict)
                    {
                        bankomat.Banknotes[keyValuePair.Key] = bankomat.Banknotes[keyValuePair.Key] - keyValuePair.Value;
                        Console.WriteLine($"Банкомат выдал {keyValuePair.Value} купюр по {(int)keyValuePair.Key} руб.");
                    }
                    
                    Form.WaitComand(bankomanNum);
                }
            }
        }

        private Dictionary<BanknoteType, int> TryWithdraw(double amount, int bankomanNum)
        {
            Bankomat bankomat = this.Bank.Bankomats[bankomanNum];

            Dictionary<BanknoteType, int> result = new Dictionary<BanknoteType, int>();

            foreach (var banknote in bankomat.Banknotes.Reverse())
            {
                while (amount >= (int)banknote.Key && bankomat.Banknotes[banknote.Key] > 0)
                {
                    amount -= (int)banknote.Key;
                    
                    int sdf;
                    if (!result.TryGetValue(banknote.Key, out sdf))
                    {
                        sdf = 0;
                    }
                    
                    result[banknote.Key] = sdf + 1;
                }
            }

            if (amount != 0)
            {
                result.Clear();
            }

            return result;
        }
        
        //public void DepositMoney(int bankomatNum, AccountType accountType, double amount)
        
       // public double GetBalanceByCardNum

    }
}