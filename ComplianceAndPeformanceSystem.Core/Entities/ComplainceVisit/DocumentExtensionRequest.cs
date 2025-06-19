namespace ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit
{
    public class DocumentExtensionRequest : TrackedEntity
    {
        public long LicensedEntityId { get; set; }
        public Guid ComplianceDetailsID { get; set; }
        public ComplianceDetails? ComplianceDetails { get; set; }

        public int? RequestedDays { get; set; }
        public string? Reason { get; set; }
        public int? ExtensionStatus { get; set; }
        public DateTime? ReviewedAt { get; set; }
        public string? DecisionReason { get; set; }
        public int? FinalDays { get; set; }

        public ICollection<ExtensionStatusHistory>? StatusHistories { get; set; }
    }
}
