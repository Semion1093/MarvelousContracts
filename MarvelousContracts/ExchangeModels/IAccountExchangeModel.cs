using Marvelous.Contracts.Enums;

namespace Marvelous.Contracts.ExchangeModels
{
    public interface IAccountExchangeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Currency CurrencyType { get; set; }
        public int LeadId { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime? LockDate { get; set; }
    }
}
