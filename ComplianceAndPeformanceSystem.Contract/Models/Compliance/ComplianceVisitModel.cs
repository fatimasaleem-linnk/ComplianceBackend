namespace ComplianceAndPeformanceSystem.Contract.Models;

public class ComplianceVisitModel
{
    public Guid Id { get; set; }
    public Guid ComplianceRequestId { get; set; }
    public long LicensedEntityId { get; set; }
    public long ActivityId { get; set; }
    public long PlantNameId { get; set; }
    public long? LocationId { get; set; }
    public long? QuarterPlannedForVisitId { get; set; }
    public long VisitTypeId { get; set; }
    public DateTime VisitDate { get; set; }
    public long DesignedCapacity  { get; set; }
    public string? VisitReferenceNumber { get; set; }
}
