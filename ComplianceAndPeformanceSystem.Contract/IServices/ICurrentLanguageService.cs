
using ComplianceAndPeformanceSystem.Contract.Enums;

namespace ComplianceAndPeformanceSystem.Contract.IServices;

public interface ICurrentLanguageService
{
    public LanguageEnum Language { get; set; }
}
