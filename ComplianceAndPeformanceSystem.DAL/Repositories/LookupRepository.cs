using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using Microsoft.EntityFrameworkCore;

namespace ComplianceAndPeformanceSystem.DAL.Repositories;

public class LookupRepository(IComplianceAndPeformanceDbContext dbContext,ICurrentLanguageService currentLanguageService) : ILookupRepository
{
    public async Task<List<CategoryLookupDto>> GetCategoryLookup()
    {
        var list = dbContext.CategoryLookup.AsQueryable();


        var result = await list?.ToListAsync();
        return result.Select(s => new CategoryLookupDto() { Id = s.Id, Name = currentLanguageService.Language == LanguageEnum.En ? s.NameEn : s.NameAr })?.ToList();
    }

    public async Task<List<LookupValueDto>> GetLookupValue(LookupQueryModel model)
    {
        var list = dbContext.LookupValue
           .Include(x => x.Category)
           .Where(s => model.CategoryId.Any(a => a == s.CategoryId)).AsQueryable();

        if (!string.IsNullOrWhiteSpace(model.Value))
            list = list.Where(s => s.ValueEn.Contains(model.Value) || s.ValueAr.Contains(model.Value));

        var result = await list?.ToListAsync();
        return result.Select(s => new LookupValueDto () { Id = s.Id, CategoryName = currentLanguageService.Language == LanguageEnum.En ? s.Category.NameEn : s.Category.NameAr  , Value = currentLanguageService.Language == LanguageEnum.En ? s.ValueEn : s.ValueAr })?.ToList();
    }
}
