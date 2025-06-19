namespace ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit
{
    public class VisitDocumentDto
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? URLs { get; set; }
        public string? Path { get; set; }
        public string? Type { get; set; }
        public string? Url { get; set; }
        public Guid? ComplianceDetailsID { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime? AssignedOn { get; set; }
        public DateTime? LastSendDate { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
