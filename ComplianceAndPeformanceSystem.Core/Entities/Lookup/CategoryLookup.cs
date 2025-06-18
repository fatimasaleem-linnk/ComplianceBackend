namespace ComplianceAndPeformanceSystem.Core.Entities;

public class CategoryLookup
{
    public long Id { get; set; }
    public required string NameEn { get; set; }
    public required string NameAr { get; set; }
    public ICollection<LookupValue>? LookupValues { get; set; }
}
