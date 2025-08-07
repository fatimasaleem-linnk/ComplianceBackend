using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using Microsoft.EntityFrameworkCore;

namespace ComplianceAndPeformanceSystem.DAL.Repositories;

public class TemplateRepository(IComplianceAndPeformanceDbContext dbContext,ICurrentLanguageService currentLanguageService) : ITemplateRepository
{
    public async Task<ResponseResult<bool>> SaveTemplate(TemplateModel model)
    {
        var record = await dbContext.Templates.FirstOrDefaultAsync(s => s.Id == model.Id);
        if (record != null)
        {
            record.Subject = model.Subject;
            record.Content = model.Content;
            await dbContext.SaveChangesAsync();
        }
        return ResponseResult<bool>.Success(true);
    }

    public async Task<ResponseResult<List<TemplateDto>>> GetTemplates(TemplateTypeEnum type)
    {
        List<TemplateDto> templates = new List<TemplateDto>();
        var records = dbContext.Templates.Where(x => x.TemplateTypeId == (long)type).Include(s => s.TemplateType).AsQueryable();
        if (records != null)
        {
            templates = await records.Select(s => new TemplateDto()
            {
                TemplateTypeId = s.TemplateTypeId,
                Content = s.Content,
                Id = s.Id,
                Role = s.Role,
                Subject = s.Subject,
                TemplateTypeName = currentLanguageService.Language == LanguageEnum.Ar ? s.TemplateType.ValueAr : s.TemplateType.ValueEn
            }).ToListAsync();
        }
        return ResponseResult<List<TemplateDto>>.Success(templates);
    }

}
