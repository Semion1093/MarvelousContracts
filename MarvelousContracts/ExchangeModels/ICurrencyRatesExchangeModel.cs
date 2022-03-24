namespace Marvelous.Contracts.ExchangeModels
{
    public interface ICurrencyRatesExchangeModel
    {
        public Dictionary<string, decimal> Rates { get; set; }
    }
} 



