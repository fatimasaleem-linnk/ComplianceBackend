using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;

namespace ComplianceAndPeformanceSystem.Contract.IRepositories;

public interface IUserRepository
{
    Task<ResponseResult<List<UserDto>>> GetUsers(List<string> rolesName);
    Task<ResponseResult<List<UserDto>>> GetUsersByIds(List<string> ids);
    //Task<ResponseResult<UserDto>> GetUser(int userId);
}
