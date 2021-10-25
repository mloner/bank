using System;

namespace Bank.Models
{
    public class Card
    {
        public string Number { get; set; }
        public DateTime ExpDatetime { get; set; }
        public bool Blocked { get; set; }
    }
}