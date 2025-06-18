using Microsoft.Extensions.Options;
using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using System.Security.Claims;
using System.Data;
using ComplianceAndPeformanceSystem.Contract.IRepositories;

namespace ComplianceAndPeformanceSystem.API.Services;

public class CurrentUserService : ICurrentUserService
{

    public CurrentUserService(IHttpContextAccessor httpContextAccessor, IUserRepository userRepository)
    {
        User = new UserInfoModel();
        if (httpContextAccessor != null && httpContextAccessor.HttpContext != null && httpContextAccessor.HttpContext?.User?.Identity?.IsAuthenticated == true)
        {
            User.UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue("UserId");
            //var user = userRepository.GetUser(int.Parse(User.UserId)).Result;

            User.UserName = httpContextAccessor.HttpContext?.User?.FindFirstValue("UserName");
            User.UserEmail = httpContextAccessor.HttpContext?.User?.FindFirstValue("UserEmail");
            User.Role = httpContextAccessor.HttpContext?.User?.FindFirstValue("Roles")?.Split(',')?.ToList();
        }

    }
    public UserInfoModel User { get; set; }
}
