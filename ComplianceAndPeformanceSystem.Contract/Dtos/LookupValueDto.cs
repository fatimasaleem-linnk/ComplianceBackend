using ComplianceAndPeformanceSystem.Core.Entities;

namespace ComplianceAndPeformanceSystem.Contract.Dtos;

public class LookupValueDto
{
    public long Id { get; set; }
    public long CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string? Value { get; set; }

}
