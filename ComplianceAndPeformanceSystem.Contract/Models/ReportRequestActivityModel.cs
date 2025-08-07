using Microsoft.AspNetCore.Http;

namespace ComplianceAndPeformanceSystem.Contract.Models;

public class ReportRequestActivityModel
{
    public Guid Id { get; set; }
    public Guid ReportId { get; set; }
    public string? RequestComment { get; set; }
    public List<IFormFile>? RequestAttachments { get; set; }
    public bool? IsReply { get; set; }
    public string? ReplyComment { get; set; }
    public List<IFormFile>? ReplyAttachments { get; set; }
    public DateTime CreatedDate { get; set; }

}
