using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.Contract.IRepositories;

public interface ITemplateRepository
{
    Task<ResponseResult<List<TemplateDto>>> GetTemplates(TemplateTypeEnum type);
    Task<ResponseResult<bool>> SaveTemplate(TemplateModel model);

}
