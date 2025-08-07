using ComplianceAndPeformanceSystem.Core.Entities;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class DocumentExtensionRequestDto
{
    public Guid Id { get; set; }
    public Guid ComplianceDetailsID { get; set; }
    public int? RequestedDays { get; set; }
    public string? Reason { get; set; }
    public string? LicensedEntityName { get; set; }
    public long LicensedEntityId { get; set; }

    public ComplianceDetails? ComplianceDetails { get; set; }
    public string? ExtensionStatus { get; set; }
    public int? Status { get; set; }
    public DateTime? ReviewedAt { get; set; }
    public string? DecisionReason { get; set; }
    public int? FinalDays { get; set; }

    public string? CreatedOn { get; set; }
    public string? CreatedByUserName { get; set; }
    public string? CreatedByID { get; set; }
    public string? CreatedByEmail { get; set; }

    public List<ExtensionStatusHistoryDto>? ExtensionStatusHistory { get; set; }
}

public class ExtensionRequestModel
{
    public Guid ComplianceDetailsID { get; set; }
    public int? RequestedDays { get; set; }
    public string? Reason { get; set; }
}