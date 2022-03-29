using Marvelous.Contracts.Enums;

namespace Marvelous.Contracts.ExchangeModels
{
    public class LeadFullExchangeModel : LeadShortExchangeModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public bool IsBanned { get; set; }
    }
}
