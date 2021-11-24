using System.Collections.Generic;

namespace Bank.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        
        public Card Card { get; set; }
        public List<Account> Accounts { get; set; }
    }
}