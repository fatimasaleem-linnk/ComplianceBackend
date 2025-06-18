namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ComplianceSpecialist : TrackedEntity
{
    public Guid ComplianceRequestId { get; set; }
    public string SpecialistUserId { get; set; }
    public string SpecialistUserName { get; set; }
    public string SpecialistUserEmail { get; set; }
    public virtual ComplianceRequest? ComplianceRequest { get; set; }
}
