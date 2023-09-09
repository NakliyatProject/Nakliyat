using Domain.Entities.Common;

namespace Domain.Entities
{
    public class Company : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string ReviewScore { get; set; }

        // public string UserRole { get; set; }
    }
}
