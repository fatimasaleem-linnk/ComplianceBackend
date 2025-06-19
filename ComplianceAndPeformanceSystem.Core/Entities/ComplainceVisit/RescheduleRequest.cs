using System.ComponentModel.DataAnnotations;

namespace ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit
{
    public class RescheduleRequest
    {
        [Key]
        public int Id { get; set; }
        public long LicensedEntityId { get; set; }
        public Guid ComplianceDetailsID { get; set; }
        public ComplianceDetails? ComplianceDetails { get; set; }
        public string? RequestedByUserId { get; set; }
        public DateTime RequestedAt { get; set; }
        public DateTime ProposedDate { get; set; }
        public string Reason { get; set; } = "";
        public int Status { get; set; } // Pending, Approved, Rejected
        public DateTime? ReviewedAt { get; set; }
        public string? ReviewedByUserId { get; set; }
        public string? ReviewReason { get; set; }
    }
}
