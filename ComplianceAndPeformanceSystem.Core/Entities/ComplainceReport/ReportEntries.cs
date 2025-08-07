using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ReportEntries
{
    [Key]
    public int Id { get; set; } = new int();
    public string? Name { get; set; }
    public string? NameAr { get; set; }
    public bool IsDeleted { get; set; } = false;
    public int? SupCategoryID { get; set; }
    [ForeignKey("SupCategoryID")]
    public ReportSubCategory? SubCategory { get; set; }
}
