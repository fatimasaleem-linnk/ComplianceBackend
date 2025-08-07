namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class RequestRescheduleDto
{
    public int Id { get; set; }
    public Guid ComplianceDetailsID { get; set; }
    public long LicensedEntityId { get; set; }
    public string? RequestedByUserId { get; set; }
    public DateTime RequestedAt { get; set; }
    public DateTime ProposedDate { get; set; }
    public string Reason { get; set; } = "";
    public string? Status { get; set; } // Pending, Approved, Rejected
    public int? StatusID { get; set; } // Pending, Approved, Rejected
    public DateTime? ReviewedAt { get; set; }
    public int? ReviewedByUserId { get; set; }
    public string? ReviewReason { get; set; }
}

public class ReviewRescheduleDto
{
    public Guid ComplianceDetailsID { get; set; }
    public long LicensedEntityId { get; set; }
    public int RequestId { get; set; }
    public bool Approve { get; set; }
    public string? Reason { get; set; }
    public bool ApprovalWithEdit { get; set; }
    public DateTime NewProposedDate { get; set; }
    public int? Status { get; set; }
}


