using ComplianceAndPeformanceSystem.Contract.IRepositories;
using ComplianceAndPeformanceSystem.DAL.Repositories;
using Hangfire;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ComplianceAndPeformanceSystem.DAL;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ComplianceAndPeformanceDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ComplianceAndPeformanceDatabase")));



        services.AddScoped<IComplianceAndPeformanceDbContext>(provider => provider.GetService<ComplianceAndPeformanceDbContext>());


        services.AddDbContext<SWAESContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("SWAESDatabase")));



        services.AddScoped<ISWAESContext>(provider => provider.GetService<SWAESContext>());


        services.AddHangfire(x => x.UseSqlServerStorage(configuration.GetConnectionString("ComplianceAndPeformanceDatabase")));
        services.AddHangfireServer();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ILookupRepository, LookupRepository>();
        services.AddScoped<IComplianceRequestRepository, ComplianceRequestRepository>();
        services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }


    public static void MigrateDatabase(this IApplicationBuilder app)
    {
        
        using (var scope = app.ApplicationServices.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ComplianceAndPeformanceDbContext>();
            db.Database.Migrate();
        }
    }
}
