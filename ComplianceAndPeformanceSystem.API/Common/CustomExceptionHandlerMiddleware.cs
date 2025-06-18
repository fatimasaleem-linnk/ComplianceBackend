using Newtonsoft.Json;
using ComplianceAndPeformanceSystem.Contract.Common.Exceptions;
using Serilog;
using System.Net;
using ILogger = Serilog.ILogger;

namespace ComplianceAndPeformanceSystem.API.Common;

public class CustomExceptionHandlerMiddleware
{
    private static readonly ILogger _logger = Log.ForContext<CustomExceptionHandlerMiddleware>();
    private readonly RequestDelegate _next;

    public CustomExceptionHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.Error($"error for {context.Request.Path}  {context.Request.Body}");
            _logger.Error($"Exception Message is: {ex.Message}");
            _logger.Error($"Exception Stack Trace is: {ex.StackTrace}");
            await HandleExceptionAsync(context, ex);
        }
    }

    private Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        var code = HttpStatusCode.InternalServerError;

        var result = string.Empty;

        switch (exception)
        {
            case ValidationException validationException:
                code = HttpStatusCode.BadRequest;
                result = JsonConvert.SerializeObject(validationException.Failures);
                break;
            case BadRequestException badRequestException:
                code = HttpStatusCode.BadRequest;
                result = badRequestException.Message;
                break;
            case NotFoundException _:
                code = HttpStatusCode.NotFound;
                break;
        }

        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)code;

        if (result == string.Empty)
        {
            result = JsonConvert.SerializeObject(new { error = exception.Message });
        }

        return context.Response.WriteAsync(result);
    }
}

public static class CustomExceptionHandlerMiddlewareExtensions
{
    public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<CustomExceptionHandlerMiddleware>();
    }
}

