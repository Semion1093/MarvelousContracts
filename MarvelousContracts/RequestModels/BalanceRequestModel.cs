using Marvelous.Contracts.Enums;

namespace Marvelous.Contracts.RequestModels
{
    public class BalanceRequestModel
    {
        public List<int> AccountIds { get; set; }
        public Currency Currency { get; set; }
    }
}
