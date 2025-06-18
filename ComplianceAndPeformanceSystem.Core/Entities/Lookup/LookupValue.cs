namespace ComplianceAndPeformanceSystem.Core.Entities;

public class LookupValue : TrackedEntity
{
    public long Id { get; set; }
    public long CategoryId { get; set; }
    public string? ValueEn { get; set; }
    public string? ValueAr { get; set; }
    public virtual CategoryLookup? Category { get; set; }
    public virtual ICollection<ComplianceDetails> LicensedEntities { get; set; }
    public virtual ICollection<ComplianceDetails> Activities { get; set; }
    public virtual ICollection<ComplianceDetails> PlantNames { get; set; }
    public virtual ICollection<ComplianceDetails> Locations { get; set; }
    public virtual ICollection<ComplianceDetails> QuarterPlannedForVisits { get; set; }
    public virtual ICollection<ComplianceDetails> VisitTypes { get; set; }
    public virtual ICollection<ComplianceRequest> Status { get; set; }
    public virtual ICollection<ComplianceDetails> VisitStatus { get; set; }
}
