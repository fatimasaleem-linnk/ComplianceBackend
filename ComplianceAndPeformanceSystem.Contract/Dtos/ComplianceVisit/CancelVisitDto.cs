namespace ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit
{
    public class CancelVisitDto
    {
        public Guid ComplianceDetailsId { get; set; }
        public string Reason { get; set; } = "";
    }
}
