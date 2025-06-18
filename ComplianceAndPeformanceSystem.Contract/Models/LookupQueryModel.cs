using ComplianceAndPeformanceSystem.Contract.Enums;

namespace ComplianceAndPeformanceSystem.Contract.Models;

public class LookupQueryModel
{
    public required List<long> CategoryId { get; set; }
    public string? Value { get; set; }
}
