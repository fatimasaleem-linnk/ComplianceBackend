using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ComplianceAndPeformanceSystem.BootStrapper;

public interface IApplicationInitalizer
{
    void ConfigureApplication(IServiceCollection services);

    void ConfigurePersistence(IServiceCollection services, IConfiguration configuration);
    void ConfigureNotification(IServiceCollection services, IConfiguration configuration);
}
