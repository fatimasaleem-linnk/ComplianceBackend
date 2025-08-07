namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ReportRequestActivityDto
{
    public Guid Id { get; set; }
    public Guid ReportId { get; set; }
    public string RequestComment { get; set; }
    public List<AttachmentDto> RequestAttachments { get; set; }
    public bool IsReply { get; set; }
    public string ReplyComment { get; set; }
    public List<AttachmentDto> ReplyAttachments { get; set; }
    public DateTime CreatedDate { get; set; }

    public ComplianceReportDto ComplianceReport { get; set; }
}
