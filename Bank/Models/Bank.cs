using System.Collections.Generic;
using System.Linq;

namespace Bank.Models
{
    public class Bank
    {
        public List<Bankomat.Bankomat> Bankomats { get; set; }
        public List<Client> Clients { get; set; }
        public List<Card> Cards { get; set; }

        public Bank()
        {
            
        }

        public void GetAllCards()
        {
            Cards = Clients.Select(x => x.Card).ToList();
        }
        
    }
}