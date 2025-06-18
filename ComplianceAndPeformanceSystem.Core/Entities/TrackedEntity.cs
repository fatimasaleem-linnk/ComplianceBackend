namespace ComplianceAndPeformanceSystem.Core.Entities;

public class TrackedEntity : BaseEntity
{
    public string? CreatedByID { get; set; }
    public string? CreatedByUserName { get; set; }
    public string? CreatedByEmail { get; set; }
    public  DateTime CreatedOn { get; set; }
    public string? ModifiedByID { get; set; }
    public string? ModifiedByUserName { get; set; }
    public string? ModifiedByEmail { get; set; }
    public  DateTime ModifiedOn { get; set; }
}
