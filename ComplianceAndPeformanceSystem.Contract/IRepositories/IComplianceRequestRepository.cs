using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Contract.Models.Compliance;

namespace ComplianceAndPeformanceSystem.Contract.IRepositories;

public interface IComplianceRequestRepository
{
    Task CreateComplianceRequest();
    Task UpdateRemainingDays();
    Task<ResponseResult<List<ComplianceNotificationMessageDto>>> GetComplianceNotifications(List<string> rolesName);
    Task<ResponseResult<ComplianceRequestDto>> GetComplianceRequest(bool isEmail = false);
    Task<ResponseResult<List<ComplianceActivityDto>>> GetComplianceActivities(Guid requestId);
    Task<ResponseResult<string>> GetComplianceApproval(Guid requestId);
    Task<ResponseResult<KeyValuePair<List<string>, bool>>> AssignComplianceSpecialist(AssignComplianceSpecialistModel model);
    Task<ResponseResult<bool>> SaveCompliancePlan(CompliancePlanModel model);
    Task<ResponseResult<bool>> DeleteCompliancePlan(Guid planId);
    Task<ResponseResult<string>> SendComplianceRequest(Guid requestId);
    Task<ResponseResult<string>> SendComplianceApprovalToPerformanceMonitoringManager(Guid requestId);
    Task<ResponseResult<bool>> ApproveOrRejectComplianceRequest(ApproveOrRejectComplianceRequestModel model, ComplianceStatusEnum status);
    Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail(Guid id);
    Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null);
    Task<ResponseResult<List<CompliancePlanDto>>> GetVisitsByStatusForLoggedInUser(string LoggedInUserId, long visitStatusId);
    Task<List<CompliancePlanDto>> GetUnscheduledVisitsForCurrentQuarter();
    Task<List<CompliancePlanDto>> GetNewVisitsForCurrentQuarter();
    Task<ResponseResult<List<ComplianceVisitSpecialistModel>>> GetComplianceVisitSpecialists(Guid complianceDetailId);
    Task<ResponseResult<KeyValuePair<List<string>, bool>>> AssignComplianceVisitSpecialist(AssignComplianceVisitSpecialistModel model);
    Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists();



}
