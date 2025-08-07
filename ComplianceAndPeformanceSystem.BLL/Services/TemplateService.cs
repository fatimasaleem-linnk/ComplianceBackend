using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.BLL.Services;

public class TemplateService(IUnitOfWork unitOfWork) : ITemplateService
{
    public async Task<ResponseResult<bool>> SaveTemplate(TemplateModel model)
    {
        return await unitOfWork.TemplateRepository.SaveTemplate(model);
    }

    public async Task<ResponseResult<List<TemplateDto>>> GetTemplates(TemplateTypeEnum type)
    {
        return await unitOfWork.TemplateRepository.GetTemplates(type);
    }

}
