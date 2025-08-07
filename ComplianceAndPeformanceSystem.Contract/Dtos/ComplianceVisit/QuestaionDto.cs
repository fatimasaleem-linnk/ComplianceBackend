namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class QuestaionDto
{
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
}
