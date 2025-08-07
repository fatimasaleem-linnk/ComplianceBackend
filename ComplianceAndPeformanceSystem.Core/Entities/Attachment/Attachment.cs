namespace ComplianceAndPeformanceSystem.Core.Entities;

public class Attachment : TrackedEntity
{
    public string AttachmentName { get; set; }
    public string AttachmentGuid { get; set; }
    public string EntityName { get; set; }
    public Guid EntityId { get; set; }
    public long AttachmentTypeId { get; set; }
    public LookupValue AttachmentType { get; set; }
}
