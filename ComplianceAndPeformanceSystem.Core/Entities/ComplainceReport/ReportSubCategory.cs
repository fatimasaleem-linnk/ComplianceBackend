using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ReportSubCategory
{
    [Key]
    public int Id { get; set; } = new int();
    public string? Name { get; set; }
    public string? NameAr { get; set; }
    public bool IsDeleted { get; set; } = false;

    public int? CategoryID { get; set; }
    [ForeignKey("CategoryID")]
    public ReportCategory? Category { get; set; }
    public ICollection<ReportEntries>? Entries { get; set; }
}
