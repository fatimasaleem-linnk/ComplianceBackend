namespace ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit
{
    public class TeamShortageDto
    {
        public Guid Id { get; set; }
        public Guid ComplianceDetailsId { get; set; }
        public DateTime? VisitDate { get; set; }
        public long? LicensedEntityId { get; set; }
        public string? LicensedEntityName { get; set; }
        public string? ShortageReason { get; set; }
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
    }
}
