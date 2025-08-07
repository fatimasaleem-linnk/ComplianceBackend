using System.ComponentModel.DataAnnotations;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ActivityLog
{
    [Key]
    public Guid Id { get; set; }
    public string Action { get; set; }
    public string ActorId { get; set; }
    public string ActorRole { get; set; }
    public DateTime ActionTime { get; set; }
    public string Description { get; set; }
    public Guid RelatedEntityId { get; set; } // Plan, Evidence, or Report ID
}
