using System;

namespace Bank.Models
{
    public class Card
    {
        public string Number { get; set; }
        public DateTime ExpDatetime { get; set; }
        public bool Blocked { get; set; }
        
        public int Attempts { get; set; }
        public string Pin { get; set; }

        public Card()
        {
            Attempts = 3;
        }
    }
    
}