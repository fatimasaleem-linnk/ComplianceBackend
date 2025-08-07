using System.ComponentModel.DataAnnotations;

namespace ComplianceAndPeformanceSystem.Core.Entities;

public class ReportCategory
{
    [Key]
    public int Id { get; set; } = new int();
    public string? Name { get; set; }
    public string? NameAr { get; set; }
    public bool IsDeleted { get; set; } = false;
    public ICollection<ReportSubCategory>? SubCategories { get; set; }
}
