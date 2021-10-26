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

        public Bankomat()
        {
            CardReader = new CardReader();
            CashDispenser = new CashDispenser();
            CheckPrinter = new CheckPrinter();
        }

        public void InsertCard(string cardNumber, string expDate)
        {
            var expDateParts = expDate.Split('/').ToList();
            CurrentCard = new Card()
            {
                Number = cardNumber,
                ExpDatetime = new DateTime(int.Parse("20" + expDateParts[1]), int.Parse(expDateParts[0]), 1)
            };
        }
    }
}