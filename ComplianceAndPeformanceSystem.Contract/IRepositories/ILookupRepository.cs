using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.Contract.IRepositories;

public interface ILookupRepository
{
    public Task<List<CategoryLookupDto>> GetCategoryLookup();
    public Task<List<LookupValueDto>> GetLookupValue(LookupQueryModel model);

}
