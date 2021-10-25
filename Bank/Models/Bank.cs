using System.Collections.Generic;

namespace Bank.Models
{
    public class Bank
    {
        public List<Bankomat> Bankomats { get; set; }
        public List<Client> Clients { get; set; }

        public Bank()
        {
            
        }
        
    }
}