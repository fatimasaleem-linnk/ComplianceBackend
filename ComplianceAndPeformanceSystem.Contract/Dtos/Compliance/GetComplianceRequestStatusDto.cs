namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class GetComplianceRequestStatusDto
{
    public string? PlanName { get; set; }
    public DateTime? LastSendDate { get; set; }
    public List<StateDto>? Status { get; set; }
}

public class StateDto
{
    public bool? IsApproved { get; set; }
    public string? StatusName { get; set; }
}
