using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class PreviousRecommendations
{
    [Key]
    public int ID { get; set; } = new int();
    public DateTime? VisitDate { get; set; }
    public int? CompletionStatusID { get; set; }
    public string? Comments { get; set; }
    public string? Action { get; set; }

    public Guid ReportID { get; set; }
    [ForeignKey(nameof(ReportID))]
    public ComplianceReport? ComplianceReport { get; set; }
}
