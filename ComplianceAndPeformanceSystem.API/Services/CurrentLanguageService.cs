using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IServices;

namespace ComplianceAndPeformanceSystem.API.Services;

public class CurrentLanguageService : ICurrentLanguageService
{

    public CurrentLanguageService(IHttpContextAccessor httpContextAccessor)
    {
        var userLanguage = httpContextAccessor.HttpContext?.Request.Headers["Accept-Language"].ToString();
        if (userLanguage == null)
            Language = LanguageEnum.Ar;

        Language = userLanguage == "en" ? LanguageEnum.En : LanguageEnum.Ar;

    }
    public LanguageEnum Language { get; set; }
}
