using Marvelous.Contracts.Enums;

namespace Marvelous.Contracts.ResponseModels
{
    public class TransactionResponseModel
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public Currency Currency { get; set; }
    }
}
