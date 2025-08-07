using System.ComponentModel.DataAnnotations;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ComplianceReportReview
{
    [Key]
    public Guid Id { get; set; }
    public Guid ComplianceReportId { get; set; }
    public string ReviewerRole { get; set; } // "ComplianceManager", "DirectorGeneral"
    public bool? IsApproved { get; set; }
    public string ReasonForReturn { get; set; }
    public DateTime ReviewedOn { get; set; }
    public string ReviewedById { get; set; }
}
