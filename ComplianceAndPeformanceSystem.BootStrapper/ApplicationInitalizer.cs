using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ComplianceAndPeformanceSystem.BLL;
using ComplianceAndPeformanceSystem.DAL;
using ComplianceAndPeformanceSystem.Notification;


namespace ComplianceAndPeformanceSystem.BootStrapper;

public class ApplicationInitalizer : IApplicationInitalizer
{
    public void ConfigureApplication(IServiceCollection services)
    {
        services.AddApplicationServices();
    }

    public void ConfigurePersistence(IServiceCollection services, IConfiguration configuration)
    {
        services.AddPersistence(configuration);
    }

    public void ConfigureNotification(IServiceCollection services, IConfiguration configuration)
    {
        services.AddNotification(configuration);
    }
}
