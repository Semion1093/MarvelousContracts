using Marvelous.Contracts.Enums;

namespace Marvelous.Contracts.ExchangeModels
{
    public interface ILeadShortExchangeModel
    {
        public int Id { get; set; }
        public Role Role { get; set; }
    }
}

