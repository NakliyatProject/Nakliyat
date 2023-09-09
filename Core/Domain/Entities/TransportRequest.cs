using Domain.Entities.Common;

namespace Domain.Entities
{
    public class TransportRequest : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid CompanyId { get; set; }
        public Company TransportCompany { get; set; }
        public string RequestType { get; set; }
        public string Statement { get; set; }
        public bool ApprovalStatus { get; set; }
        public DateTime StratingDate { get; set; }
        public DateTime FinishingDate { get; set;}
    }
}
