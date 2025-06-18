using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ComplianceAndPeformanceSystem.API.Services;
using ComplianceAndPeformanceSystem.BootStrapper;
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.IServices;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

namespace ComplianceAndPeformanceSystem.API.Extensions;

public static class ServiceExtension
{
    public static void ConfigureAuthenticationSettings(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSecret = configuration.GetSection("AppSettings").GetValue<string>("JwtKey");
        var key = Encoding.ASCII.GetBytes(jwtSecret);

        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(options =>
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSecret!));
            options.TokenValidationParameters = TokenValidationParametersFactory.Create(key);
        });

        services.AddScoped<ICurrentUserService, CurrentUserService>();
        services.AddScoped<ICurrentLanguageService, CurrentLanguageService>();
    }

    public static class TokenValidationParametersFactory
    {
        public static TokenValidationParameters Create(SymmetricSecurityKey key)
        {
            return new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero // Optional: to avoid having to wait for token expiration it give 5 min buffer
            };
        }
    }

    public static void InitializeApplication(this IServiceCollection services, IConfiguration configuration)
    {
        var initalizeType = configuration.GetValue<string>("InitializerType");
        var rootDirectory = GetAssmeblyFolder();

        // load bootstrapper Assembly
        string[] bootstrapperAssembly = initalizeType.Split(',');
        var initalizerAssembly = bootstrapperAssembly[0];
        var initalizerName = bootstrapperAssembly[1];
        var assemblyBootstrapper = LoadAssembly($@"{rootDirectory}\{initalizerAssembly}");

        var type = assemblyBootstrapper.GetType(initalizerName);
        if (!(Activator.CreateInstance(type) is IApplicationInitalizer initalizer))
        {
            throw new InvalidOperationException("Couldn't load initalizer");
        }
        // start initialization
        initalizer.ConfigurePersistence(services, configuration);
        initalizer.ConfigureNotification(services, configuration);
        initalizer.ConfigureApplication(services);

        services.Configure<AppSettings>(configuration.GetSection("AppSettings"));
        services.Configure<JWTModel>(configuration.GetSection("JWTValidator"));
        services.AddSingleton<AppSettings, AppSettings>();
        services.AddSingleton<JWTModel, JWTModel>();

    }

    private static string GetAssmeblyFolder()
    {
        var currentAssemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        var splitterIndex = currentAssemblyPath.LastIndexOf('\\');
        return currentAssemblyPath.Substring(0, splitterIndex);
    }

    private static Assembly LoadAssembly(string assemblyPath) => AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);

    public static void AddSwaggerConfig(this IServiceCollection services)
    {
        services.AddSwaggerGen(swagger =>
        {


            swagger.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Authorization: Bearer {token}"
            });

            swagger.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[]{ }
                }
            });

            string xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

            swagger.IncludeXmlComments(xmlPath);
        });

    }

    public static void UseCustomSwaggerConfig(this IApplicationBuilder app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }
}
