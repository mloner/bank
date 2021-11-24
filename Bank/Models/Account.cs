namespace Bank.Models
{

    public enum AccountType
    {
        Main,
        Saving
    }
    public class Account
    {
        public double Balance { get; set; }
        
        public AccountType Type { get; set; }
    }
}