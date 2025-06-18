using System.Text.Json.Serialization;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ComplianceNotificationMessageDto
{
    [JsonIgnore]
    public int Id { get; set; }
    public string MessageType { get; set; }
    public string MessageTitle { get; set; }
    public string MessageBody { get; set; }
    public string ActionUrl { get; set; }
}
