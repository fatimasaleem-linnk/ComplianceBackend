using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.BLL.Services;

public class LookupService(IUnitOfWork unitOfWork) : ILookupService
{
    public async Task<List<CategoryLookupDto>> GetCategoryLookup()
    {
        return await unitOfWork.LookupRepository.GetCategoryLookup();
    }

    public async Task<List<LookupValueDto>> GetLookupValue(LookupQueryModel model)
    {
        return await unitOfWork.LookupRepository.GetLookupValue(model);
    }


}
