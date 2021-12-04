using System.ComponentModel;

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
    public static class AccountTypeHelper {
        public static string ToStr(this AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Main:
                    return "Основной";
                case AccountType.Saving:
                    return "Сберегательный";
                default: return "";
            }
        }
    }
}