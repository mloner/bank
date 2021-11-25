using System;
using System.Linq;

namespace Bank.Models
{
    public class Bankomat
    {
        public CardReader CardReader { get; set; }
        public CashDispenser CashDispenser { get; set; }
        public CheckPrinter CheckPrinter { get; set; }
        
        public Card CurrentCard { get; set; }
        public int Id { get; set; }
        public BankomatState State { get; set; }
        
        

        public Bankomat()
        {
            CardReader = new CardReader();
            CashDispenser = new CashDispenser();
            CheckPrinter = new CheckPrinter();
            State = BankomatState.NoCard;
        }

        // говно переделывай
        public Card InsertCard(string cardNumber, string expDate)
        {
            var expDateParts = expDate.Split('/').ToList();
            Card card = new Card()
            {
                Number = cardNumber,
                ExpDatetime = new DateTime(int.Parse("20" + expDateParts[1]), int.Parse(expDateParts[0]), 1)
            };
            return card;
        }
    }
}