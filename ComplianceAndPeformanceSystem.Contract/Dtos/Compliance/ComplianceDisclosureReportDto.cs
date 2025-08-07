using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ComplianceDisclosureReportDto
{
    public Guid ComplianceDetailId { get; set; }
    public long? LocationId { get; set; }
    public string? LocationName { get; set; }  
    public long? VisitTypeId { get; set; }
    public string? VisitTypeName { get; set; }
    public long? ActivityId { get; set; }
    public string? ActivityName { get; set; }
    public List<ComplianceVisitSpecialistModel>? ComplianceVisitSpecialists { get; set; }
}
