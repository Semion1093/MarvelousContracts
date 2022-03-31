using Marvelous.Contracts.Enums;

namespace Marvelous.Contracts.RequestModels
{
    public class LeadChangeRoleRequest
    {
        public int Id { get; set; }
        public Role Role { get; set; }
    }
}
