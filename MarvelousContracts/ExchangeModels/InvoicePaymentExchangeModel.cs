namespace Marvelous.Contracts.ExchangeModels
{
    public class InvoicePaymentExchangeModel
    {
        public int AccountId { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal PaypalFee { get; set; }
        public decimal MarvelousFee { get; set; }
        public decimal TransactionAmount { get; set; }
        public long TransactionId { get; set; }
    }
}
