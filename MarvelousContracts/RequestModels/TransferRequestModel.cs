using Marvelous.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace Marvelous.Contracts.RequestModels
{
    public class TransferRequestModel
    {
        public decimal Amount { get; set; }

        public int AccountIdFrom { get; set; }

        public Currency CurrencyFrom { get; set; }

        public int AccountIdTo { get; set; }

        public Currency CurrencyTo { get; set; }
    }
}
