
using ComplianceAndPeformanceSystem.Contract.Models;

namespace ComplianceAndPeformanceSystem.Contract.IServices;

public interface ICurrentUserService
{
    public UserInfoModel User { get; set; }
}
