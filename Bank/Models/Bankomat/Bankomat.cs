using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Models.Bankomat
{
    public class Bankomat
    {
        public List<string> Journal { get; set; }
        public CardReader CardReader { get; set; }
        public CashDispenser CashDispenser { get; set; }
        public CheckPrinter CheckPrinter { get; set; }
        
        public Card CurrentCard { get; set; }
        public int Id { get; set; }
        public BankomatState State { get; set; }
        
        public Dictionary<BanknoteType, int> Banknotes { get; set; }
        
        
        

        public Bankomat()
        {
            Journal = new List<string>();
            CardReader = new CardReader();
            CashDispenser = new CashDispenser();
            CheckPrinter = new CheckPrinter();
            State = BankomatState.NoCard;
            Banknotes = new Dictionary<BanknoteType, int>()
            {
                {BanknoteType._50, 10},
                {BanknoteType._100, 12},
                {BanknoteType._200, 1},
                {BanknoteType._500, 30},
                {BanknoteType._1000, 10},
                {BanknoteType._2000, 10},
                {BanknoteType._5000, 2},
            };
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