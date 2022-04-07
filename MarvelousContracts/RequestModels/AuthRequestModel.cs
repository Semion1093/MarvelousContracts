using System.ComponentModel.DataAnnotations;

namespace Marvelous.Contracts.RequestModels
{
    public class AuthRequestModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
