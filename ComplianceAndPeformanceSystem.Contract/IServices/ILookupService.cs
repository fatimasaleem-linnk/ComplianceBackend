using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.Contract.IServices;

public interface ILookupService
{
    public Task<List<CategoryLookupDto>> GetCategoryLookup();
    public Task<List<LookupValueDto>> GetLookupValue(LookupQueryModel model);
}
