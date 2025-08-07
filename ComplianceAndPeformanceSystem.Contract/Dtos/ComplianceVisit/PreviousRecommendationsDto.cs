namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class PreviousRecommendationsDto
{
    public DateTime? VisitDate { get; set; }
    public int? CompletionStatusID { get; set; }
    public string? Comments { get; set; }
    public string? Action { get; set; }
    public Guid ReportID { get; set; }
}
