using Marvelous.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace Marvelous.Contracts.RequestModels
{
    public class TransactionRequestModel
    {
        public decimal Amount { get; set; }

        public int AccountId { get; set; }

        public Currency Currency { get; set; }
    }
}
