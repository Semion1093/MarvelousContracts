namespace Marvelous.Contracts.ExchangeModels
{
    public class LeadAuthExchangeModel : LeadShortExchangeModel
    {
        public string Email { get; set; }
        public string HashPassword { get; set; }
    }
}
