namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ExtensionStatusHistoryDto
{
    public int Id { get; set; }
    public Guid RequestId { get; set; }
    public int? OldStatus { get; set; }
    public int NewStatus { get; set; }
    public string? ActionReason { get; set; }
    public int? NewFinalDays { get; set; }
    public string ActionByUserName { get; set; } = "";
    public DateTime ActionAt { get; set; }
}
