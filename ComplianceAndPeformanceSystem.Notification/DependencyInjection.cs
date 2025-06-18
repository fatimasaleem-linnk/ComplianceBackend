
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Notification.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ComplianceAndPeformanceSystem.Notification;

public static class DependencyInjection
{

    public static IServiceCollection AddNotification(this IServiceCollection services, IConfiguration configuration)
    {
        var emailConfig = configuration
            .GetSection("EmailConfiguration")
            .Get<EmailConfigurationModel>();
        services.AddSingleton(emailConfig);



        var smsConfig = configuration
           .GetSection("SMSConfiguration")
           .Get<SMSConfigurationModel>();
        services.AddSingleton(smsConfig);

        services.AddScoped<IViewRendererService, ViewRendererService>();


        services.AddTransient<EmailNotificationService>();
        services.AddTransient<SMSNotificationService>();
        services.AddTransient<Func<NotificationTypeEnum, INotificationService>>(serviceProvider => key =>
        {
            switch (key)
            {
                case NotificationTypeEnum.SMS:
                    return serviceProvider.GetService<SMSNotificationService>();
                case NotificationTypeEnum.Email:
                    return serviceProvider.GetService<EmailNotificationService>();
                default:
                    return serviceProvider.GetService<EmailNotificationService>();
            }
        });

        services.AddRazorPages();
        services.AddControllersWithViews();

        return services;
    }
}