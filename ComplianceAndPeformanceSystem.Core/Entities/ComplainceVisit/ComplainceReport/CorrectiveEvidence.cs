using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class CorrectiveEvidence
{
    [Key]
    public Guid Id { get; set; }

    public Guid PlanId { get; set; }
    [ForeignKey(nameof(PlanId))]
    public virtual CorrectiveActionPlan? CorrectiveActionPlan { get; set; }


    public string? Comments { get; set; }
    public int? EvidenceStatus { get; set; }
}
