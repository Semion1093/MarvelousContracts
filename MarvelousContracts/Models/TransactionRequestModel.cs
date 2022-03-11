namespace Marvelous.Contracts
{
    public class TransactionRequestModel
    {
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public Currency Currency { get; set; }
    }
}
