namespace Bank.Models
{
    public class CardReader
    {
        public CardReaderState CardReaderState { get; set; }
    }
    public enum CardReaderState
    {
        Default = 0,
        Inside = 1,
    }
}