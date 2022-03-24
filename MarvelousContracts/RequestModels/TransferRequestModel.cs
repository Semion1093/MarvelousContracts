using Marvelous.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace Marvelous.Contracts.RequestModels
{
    public class TransferRequestModel
    {
        [Range(0, 99999.99)]
        public decimal Amount { get; set; }

        [Required]
        public int AccountIdFrom { get; set; }

        [EnumDataType(typeof(Currency))]
        public Currency CurrencyFrom { get; set; }

        [Required]
        public int AccountIdTo { get; set; }

        [EnumDataType(typeof(Currency))]
        public Currency CurrencyTo { get; set; }
    }
}
