namespace Marvelous.Contracts.ExchangeModels
{
    public class ServiceExchangeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
    }
}

