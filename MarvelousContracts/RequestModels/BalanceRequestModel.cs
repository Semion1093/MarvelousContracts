using Marvelous.Contracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace Marvelous.Contracts.RequestModels
{
    public class BalanceRequestModel
    {
        [Required]
        public List<int> AccountIds { get; set; }

        [Required]
        public Currency Currency { get; set; }
    }
}
