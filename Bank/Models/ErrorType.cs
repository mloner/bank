namespace Bank.Models
{
    public enum ErrorType
    {
        WrongNumber,
        Expire,
        Blocked,
        WrongPassword,
        NotEnoughAccountMoney,
        NotEnoughBankomatMoney,
        LimitIsReached
    }
}