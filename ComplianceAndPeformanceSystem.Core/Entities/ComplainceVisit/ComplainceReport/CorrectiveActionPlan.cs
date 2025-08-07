using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;
public class CorrectiveActionPlan
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportId { get; set; } // Link to main report/visit
    [ForeignKey(nameof(ReportId))]
    public virtual ComplianceReport? Report { get; set; }
    public string? LicenseEntityID { get; set; }
    public string? Description { get; set; } // Description
    public DateTime Deadline { get; set; }

    // When evidence is due
    public int Status { get; set; }
    public ICollection<CorrectiveEvidence>? Evidences { get; set; }
}


