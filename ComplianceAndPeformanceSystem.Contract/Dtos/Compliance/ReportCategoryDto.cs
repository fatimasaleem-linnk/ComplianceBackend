namespace ComplianceAndPeformanceSystem.Contract.Dtos.Compliance
{
    public class ReportCategoryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NameAr { get; set; }
        public List<ReportSubCategoryDto> SubCategories { get; set; } = new();
    }

    public class ReportSubCategoryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NameAr { get; set; }
        public List<ReportEntryDto> Entries { get; set; } = new();
    }

    public class ReportEntryDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? NameAr { get; set; }
    }
}
