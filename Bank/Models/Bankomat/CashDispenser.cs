namespace Bank.Models
{
    public class CashDispenser
    { 
        public CashDispenserState CashDispenserState { get; set; }
    }

    public enum CashDispenserState
    {
        Default = 0,
        WaitForCashTaking = 1
    }
}