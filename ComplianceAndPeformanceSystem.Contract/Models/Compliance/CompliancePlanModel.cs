namespace ComplianceAndPeformanceSystem.Contract.Models;

public class CompliancePlanModel
{
    public Guid? Id { get; set; }
    public Guid ComplianceRequestId { get; set; }
    public required long LicensedEntityId { get; set; }
    public required long ActivityId { get; set; }
    public required long PlantNameId { get; set; }
    public long? LocationId { get; set; }
    public long? QuarterPlannedForVisitId { get; set; }
    public required long VisitTypeId { get; set; }
}
