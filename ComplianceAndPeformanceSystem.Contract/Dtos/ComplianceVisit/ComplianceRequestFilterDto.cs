namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ComplianceRequestFilterDto
{
    public long? VisitStatusID { get; set; }
    public long? VisitTypeID { get; set; }
    public long? LicenseeEntityID { get; set; }
    public string? VisitReferanceNumber { get; set; }
    public DateTime? VisitDate { get; set; }    // single date
}
