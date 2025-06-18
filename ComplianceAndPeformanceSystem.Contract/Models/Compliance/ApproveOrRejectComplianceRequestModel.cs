using System.Text.Json.Serialization;

namespace ComplianceAndPeformanceSystem.Contract.Models;

public class ApproveOrRejectComplianceRequestModel
{
    [JsonIgnore]
    public string? Role { get; set; }
    public Guid RequestId { get; set; }
    [JsonIgnore]
    public bool IsApproved { get; set; }
    public string Notes { get; set; }
    public int DaysForFinish { get; set; }
}
