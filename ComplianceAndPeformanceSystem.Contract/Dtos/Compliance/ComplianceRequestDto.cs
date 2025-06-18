namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ComplianceRequestDto
{
    public Guid Id { get; set; }
    public long Seq { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? AssignedOn { get; set; }
    public DateTime? LastSendDate { get; set; }
    public long? StatusId { get; set; }
    public string? StatusName { get; set; }
    public int RemainingDays { get; set; }
    public int PassedDays { get; set; }
    public string AssignTaskName { get; set; }
    public List<ComplianceSpecialistDto>? AssignedSpecialists { get; set; }
    public List<CompliancePlanDto>? CompliancePlans { get; set; }
    public List<ComplianceNotificationMessageDto>? ComplianceNotificationMessages { get; set; }
}
