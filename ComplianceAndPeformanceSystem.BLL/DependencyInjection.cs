
using ComplianceAndPeformanceSystem.BLL.Services;
using ComplianceAndPeformanceSystem.Contract.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace ComplianceAndPeformanceSystem.BLL;

public static class DependencyInjection
{

    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {

        services.AddScoped<ILookupService, LookupService>();
        services.AddScoped<IComplianceRequestService, ComplianceRequestService>();
        return services;
    }
}