﻿namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class ReportCategoryVM
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? NameAr { get; set; }
    public List<SubCategoryVM>? SubCategories { get; set; }
}
public class SubCategoryVM
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? NameAr { get; set; }
    public int? CategoryID { get; set; }
    public List<EntriesVM>? Entries { get; set; }
}
public class EntriesVM
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? NameAr { get; set; }
    public int? SupCategoryID { get; set; }
}
