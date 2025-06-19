namespace ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit
{
    public class UpdateVisitStatusDto
    {
        public int NewStatus { get; set; }
        public string? Note { get; set; }
        public Guid ComplianceDetailsID { get; set; }
    }
}
