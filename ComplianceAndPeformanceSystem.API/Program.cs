using ComplianceAndPeformanceSystem.API.Common;
using ComplianceAndPeformanceSystem.API.Extensions;
using ComplianceAndPeformanceSystem.Contract.IServices;
using Hangfire;
using Microsoft.AspNetCore.Http.Timeouts;
using Microsoft.AspNetCore.RateLimiting;
using Serilog;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.InitializeApplication(builder.Configuration);
builder.Services.ConfigureAuthenticationSettings(builder.Configuration);
// Add services to the container.
builder.Host.UseSerilog((_, _, configuration) =>
{
    configuration.ReadFrom.Configuration(builder.Configuration);
    configuration.Enrich.FromLogContext();
});
Serilog.Debugging.SelfLog.Enable(msg =>
{
    Debug.Print(msg);
    //Debugger.Break();
});

builder.Services.AddRateLimiter(rateLimiterOptions =>
{
    rateLimiterOptions.RejectionStatusCode = StatusCodes.Status429TooManyRequests;
    rateLimiterOptions.AddFixedWindowLimiter("fixed", options =>
    {
        options.PermitLimit = 1000;
        options.Window = TimeSpan.FromSeconds(30);
    });
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerConfig();
builder.Services.AddCors(options =>
    options.AddPolicy("CorsPolicy", builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin().SetIsOriginAllowed((host) => true))
);
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddHttpContextAccessor();

builder.Services.AddRequestTimeouts(options =>
{
    options.DefaultPolicy = new RequestTimeoutPolicy
    {
        Timeout = TimeSpan.FromMilliseconds(2000),
        TimeoutStatusCode = 503
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
app.UseSwagger();
app.UseCustomSwaggerConfig();
//}
app.UseHsts();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

//app.MigrateDatabase();
app.UseRateLimiter();
app.UseHangfireDashboard();
app.UseCustomExceptionHandler();
app.UseCors("CorsPolicy");



app.Use(async (context, next) =>
{
    context.Response.Headers.Add("X-Frame-Options", "DENY");
    context.Response.Headers.Add("X-XSS-Protection", "1; mode=block");
    context.Response.Headers.Add("X-Content-Type-Options", "nosniff");
    context.Response.Headers.Add("Referrer-Policy", "no-referrer");
    context.Response.Headers.Add("X-Permitted-Cross-Domain-Policies", "none");
    context.Response.Headers.Add("Content-Security-Policy", "default-src * 'unsafe-inline' 'unsafe-eval'; script-src * 'unsafe-inline' 'unsafe-eval'; connect-src * 'unsafe-inline'; img-src * data: blob: 'unsafe-inline'; frame-src *; style-src * 'unsafe-inline';");
    context.Response.Headers.Remove("X-AspNet-Version");
    context.Response.Headers.Remove("X-Powered-By");
    context.Response.Headers.Remove("Server");

    await next.Invoke();
});


app.MapControllers();

RecurringJob.AddOrUpdate<IComplianceRequestService>(
    "CreateComplianceRequestJob",
    (s) => s.CreateComplianceRequest(),
    "0 0 10 9 *");

RecurringJob.AddOrUpdate<IComplianceRequestService>(
    "UpdateRemainingDaysJob",
    (s) => s.UpdateRemainingDays(),
    Cron.Daily);

RecurringJob.AddOrUpdate<IComplianceRequestService>(
    "SendQuarterlyNotificationsToScheduleComplianceVisitsJob",
    service => service.SendQuarterlyNotificationsToScheduleComplianceVisitsAsync(),
    Cron.Daily // Runs daily to check if it's 7 days before a quarter
);

RecurringJob.AddOrUpdate<IComplianceRequestService>(
    "SendUpcomingVisitNotificationsSMSJob",
    service => service.SendUpcomingVisitNotificationsSMSAsync(),
    Cron.Daily // Runs daily to check if it's 10 days before a visit date
);

RecurringJob.AddOrUpdate<IComplianceRequestService>(
    "NotifyVisitDisclosureNotSubmittedJob",
    service => service.SendVisitDisclosureNotSubmittedNotificationAsync(),
    Cron.Daily //runs daily to check if disclosure forms are submitted by specialists within 2 days of visit assignment
);

app.Run();