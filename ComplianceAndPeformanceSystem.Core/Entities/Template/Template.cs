namespace ComplianceAndPeformanceSystem.Core.Entities;

public class Template
{
    public long Id { get; set; }
    public string Role { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public long TemplateTypeId { get; set; }

    public LookupValue TemplateType { get; set; }
}
