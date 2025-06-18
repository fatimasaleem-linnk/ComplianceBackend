namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ComplianceApproval : TrackedEntity
{
    public Guid Id { get; set; }
    public Guid ComplianceRequestId { get; set; }
    public string? ApprovalUserName { get; set; }
    public string? ApprovalEmail { get; set; }
    public required string Role { get; set; }
    public required bool? IsApproved { get; set; }
    public string? Notes { get; set; }
    public int? DaysForFinish { get; set; }

    public virtual ComplianceRequest? ComplianceRequest { get; set; }
}
