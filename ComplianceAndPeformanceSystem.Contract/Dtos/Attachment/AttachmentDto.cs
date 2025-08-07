using ComplianceAndPeformanceSystem.Contract.Enums;
using System.Text.Json.Serialization;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class AttachmentDto
{
    public Guid AttachmentId { get; set; }
    [JsonIgnore]
    public string AttachmentGuid { get; set; }
    public string AttachmentName { get; set; }
    [JsonIgnore]
    public Guid EntityId { get; set; }
    [JsonIgnore]
    public string EntityName { get; set; }
    [JsonIgnore]
    public AttachmentTypeEnum AttachmentType { get; set; }
    public byte[] Content { get; set; }
}
