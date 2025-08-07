namespace ComplianceAndPeformanceSystem.Contract.Models;

public class AssignComplianceVisitSpecialistModel
{
    public Guid RequestId { get; set; }
    public Guid ComplianceDetailsId { get; set; }
    public List<string> AssignedUserId { get; set; }
}
