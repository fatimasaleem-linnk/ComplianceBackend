using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.Contract.IServices;

public interface ITemplateService
{
    Task<ResponseResult<List<TemplateDto>>> GetTemplates(TemplateTypeEnum type);
    Task<ResponseResult<bool>> SaveTemplate(TemplateModel model);

}
