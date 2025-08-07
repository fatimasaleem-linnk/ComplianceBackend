namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class SpecialistRescheduleDto
{
    public Guid ComplianceDetailsID { get; set; }
    public long LicensedEntityId { get; set; }
    public string? RescheduleReason { get; set; } = "";
    public string? OldStatus { get; set; }
    public string? NewStatus { get; set; }
}
