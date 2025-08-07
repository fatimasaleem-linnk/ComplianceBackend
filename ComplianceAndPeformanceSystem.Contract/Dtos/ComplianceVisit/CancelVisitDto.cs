namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class CancelVisitDto
{
    public Guid ComplianceDetailsId { get; set; }
    public string Reason { get; set; } = "";
}
