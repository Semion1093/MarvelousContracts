using Marvelous.Contracts.Enums;

namespace Marvelous.Contracts.ResponseModels
{
    public class TransferResponseModel
    {
        public int IdFrom { get; set; }
        public int IdTo { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }
        public decimal Amount { get; set; }
        public decimal ConvertedAmount { get; set; }
        public int AccountIdFrom { get; set; }
        public Currency CurrencyFrom { get; set; }
        public int AccountIdTo { get; set; }
        public Currency CurrencyTo { get; set; }
    }
}
