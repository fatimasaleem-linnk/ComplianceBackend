namespace ComplianceAndPeformanceSystem.Contract.Models;

public class AssignComplianceVisitSpecialistResponseModel
{
    public bool IsUpdate { get; set; }
    public List<string> NotifyNewUsers { get; set; }
    public List<string> NotifyConflictUsers { get; set; }
}
