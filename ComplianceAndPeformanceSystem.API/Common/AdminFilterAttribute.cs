using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Enums;

namespace ComplianceAndPeformanceSystem.API.Common
{

    public class AdminFilterAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var userRoles = context.HttpContext.User?.FindFirst("Roles")?.Value?.Split(',')?.ToList();
            if (userRoles != null && userRoles.Count > 0)
                await next();

            context.Result = new UnauthorizedObjectResult(ResponseResult<object?>.Failure(new List<string> { "Unauthorized Access" },null));

        }


    }
}
