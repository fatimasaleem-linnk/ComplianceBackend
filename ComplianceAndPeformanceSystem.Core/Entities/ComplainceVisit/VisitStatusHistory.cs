using System.ComponentModel.DataAnnotations;

namespace ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit
{
    public class VisitStatusHistory
    {
        [Key]
        public int Id { get; set; }
        public Guid ComplianceDetailsId { get; set; }
        public ComplianceDetails? ComplianceDetails { get; set; }
        public string? ActionByUserId { get; set; }
        public DateTime ActionAt { get; set; }
        public string? OldStatus { get; set; }
        public string? NewStatus { get; set; }
        public string? ActionReason { get; set; }
        public DateTime? RequestedNewDate { get; set; }
    }
}
