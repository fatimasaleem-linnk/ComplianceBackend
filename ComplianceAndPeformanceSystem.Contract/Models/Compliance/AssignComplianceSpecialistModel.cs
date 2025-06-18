namespace ComplianceAndPeformanceSystem.Contract.Models;

public class AssignComplianceSpecialistModel
{
    public Guid RequestId { get; set; }
    public List<string> AssignedUserId { get; set; }
}
