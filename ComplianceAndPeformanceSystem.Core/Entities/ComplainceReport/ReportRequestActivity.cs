using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ReportRequestActivity : TrackedEntity
{
    public Guid ReportId { get; set; }
    public string? RequestComment { get; set; }
    public bool? IsReply { get; set; } = false;
    public string? ReplyComment { get; set; }

    [ForeignKey(nameof(ReportId))]
    public virtual ComplianceReport Report { get; set; }
}
