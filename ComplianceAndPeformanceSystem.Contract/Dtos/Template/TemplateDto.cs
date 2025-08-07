namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class TemplateDto
{
    public long Id { get; set; }
    public string Role { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
    public long TemplateTypeId { get; set; }
    public string TemplateTypeName { get; set; }

}
