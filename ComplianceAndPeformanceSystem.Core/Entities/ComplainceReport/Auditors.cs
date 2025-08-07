using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class Auditors
{
    [Key]
    public int ID { get; set; } = new int();
    public string? Name { get; set; }

    public Guid ReportID { get; set; }
    [ForeignKey(nameof(ReportID))]
    public ComplianceReport? ComplianceReport { get; set; }
}
