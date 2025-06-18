using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Contract.Models.Compliance;

namespace ComplianceAndPeformanceSystem.Contract.IServices;

public interface IComplianceRequestService
{
    Task<ResponseResult<List<ComplianceNotificationMessageDto>>> GetNotifications();
    Task<ResponseResult<GetComplianceRequestStatusDto>> GetComplianceRequestStatus();
    Task CreateComplianceRequest();
    Task UpdateRemainingDays();
    Task SendQuarterlyNotificationsToScheduleComplianceVisitsAsync();
    Task SendUpcomingVisitNotificationsEmailAsync();
    Task SendUpcomingVisitNotificationsSMSAsync();
    Task<ResponseResult<ComplianceRequestDto>> GetComplianceRequest();
    Task<ResponseResult<List<UserDto>>> GetComplianceSpecialist();
    Task<ResponseResult<List<ComplianceActivityDto>>> GetComplianceActivities(Guid requestId);
    Task<ResponseResult<bool>> AssignComplianceSpecialist(AssignComplianceSpecialistModel model);
    Task<ResponseResult<bool>> SaveCompliancePlan(CompliancePlanModel model);
    Task<ResponseResult<bool>> DeleteCompliancePlan(Guid planId);
    Task<ResponseResult<bool>> SendComplianceRequest(Guid requestId);
    Task<ResponseResult<bool>> ApproveComplianceRequestByComplianceManager(ApproveOrRejectComplianceRequestModel model);
    Task<ResponseResult<bool>> ReturnComplianceRequestByComplianceManager(ApproveOrRejectComplianceRequestModel model);
    Task<ResponseResult<bool>> ApproveComplianceRequestByPerformanceMonitoringManager(ApproveOrRejectComplianceRequestModel model);
    Task<ResponseResult<bool>> ReturnComplianceRequestByPerformanceMonitoringManager(ApproveOrRejectComplianceRequestModel model);
    Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail(Guid id);
    Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null);
    Task<ResponseResult<bool>> AssignComplianceVisitSpecialist(AssignComplianceVisitSpecialistModel model);
    Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists();


}
