using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class Questaion
{
    [Key]
    public int ID { get; set; }
    public int? CategoryID { get; set; }
    public string? CategoryName { get; set; }

    public int? SubCategoryID { get; set; }
    public string? SubCategoryName { get; set; }

    public int? EntryID { get; set; }
    public string? EntryName { get; set; }

    public string? Grade { get; set; }
    public string? Evidence { get; set; }
    public string? EvidencePath { get; set; }

    public Guid ReportID { get; set; }
    [ForeignKey(nameof(ReportID))]
    public ComplianceReport? ComplianceReport { get; set; }
}
