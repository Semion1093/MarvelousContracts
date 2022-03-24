using Marvelous.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace Marvelous.Contracts.RequestModels
{
    public class TransactionRequestModel
    {
        [Range(0, 99999.99)]
        public decimal Amount { get; set; }

        [Required]
        public int AccountId { get; set; }

        [EnumDataType(typeof(Currency))]
        public Currency Currency { get; set; }
    }
}
