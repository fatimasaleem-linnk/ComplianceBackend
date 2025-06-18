namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ComplianceRequest : TrackedEntity
{
    public Guid Id { get; set; }
    public long Seq { get; set; }
    public required string AssignTaskNameEn { get; set; }
    public required string AssignTaskNameAr { get; set; }
    public int RemainingDays { get; set; }
    public DateTime? AssignedOn { get; set; }
    public int PassedDays { get; set; }
    public long StatusId { get; set; }
    public DateTime? LastSendDate { get; set; }
    public virtual LookupValue Status { get; set; }
    public virtual ICollection<ComplianceDetails> ComplianceDetails { get; set; }
    public virtual ICollection<ComplianceRequestActivity> ComplianceRequestActivities { get; set; }
    public virtual ICollection<ComplianceApproval> ComplianceApprovals { get; set; }
    public virtual ICollection<ComplianceSpecialist> ComplianceSpecialists { get; set; }

}
