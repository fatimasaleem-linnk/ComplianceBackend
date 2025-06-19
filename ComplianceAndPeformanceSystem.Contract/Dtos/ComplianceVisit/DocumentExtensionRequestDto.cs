using ComplianceAndPeformanceSystem.Core.Entities;

namespace ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit
{
    public class DocumentExtensionRequestDto
    {
        public Guid Id { get; set; }
        public Guid ComplianceDetailsID { get; set; }
        public int? RequestedDays { get; set; }
        public string? Reason { get; set; }
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
}
