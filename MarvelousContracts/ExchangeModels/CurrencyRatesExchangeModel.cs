using Marvelous.Contracts.Enums;

namespace Marvelous.Contracts.ExchangeModels
{
    public class CurrencyRatesExchangeModel
    {
        public Dictionary<string, decimal> Rates { get; set; }
        public Currency BaseCurrency { get; set; }
    }
} 



