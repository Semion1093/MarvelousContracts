namespace Marvelous.Contracts.ExchangeModels
{
    public class LeadResourceExchangeModel
    {
        public int Id { get; set; }
        public int ResourceId { get; set; }
        public int Period { get; set; }
        public int Status { get; set; }
        public int LeadId { get; set; }
        public decimal Price { get; set; }
    }
}

