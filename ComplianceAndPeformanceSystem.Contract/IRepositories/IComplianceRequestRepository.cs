using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.Compliance;
using ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Contract.Models.Compliance;
using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.AspNetCore.Http;

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

    #region phase2
    Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail(Guid id);
    Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null);
    Task<ResponseResult<List<CompliancePlanDto>>> GetVisitsByStatusForLoggedInUser(string LoggedInUserId, long visitStatusId);
    Task<List<CompliancePlanDto>> GetUnscheduledVisitsForCurrentQuarter();
    Task<List<CompliancePlanDto>> GetNewVisitsForCurrentQuarter();
    Task<ResponseResult<List<ComplianceVisitSpecialistModel>>> GetComplianceVisitSpecialists(Guid complianceDetailId);
    Task<ResponseResult<AssignComplianceVisitSpecialistResponseModel>> AssignComplianceVisitSpecialists(AssignComplianceVisitSpecialistModel model);
    Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists();
    Task<List<CompliancePlanDto>> GetQuarterVisits();

    // Part 03
    Task<ResponseResult<bool>> AddAttachment(List<IFormFile> attachmentvm, Guid? ComplianceDetailsID);
    Task<ResponseResult<List<ComplianceDetailsDto>>> GetComplianceVisit();
    Task<ResponseResult<DocumentExtensionRequestDto>>? AddExtensionRequest(DocumentExtensionRequestDto request, Guid ComplianceDetailsID);
    Task<ResponseResult<DocumentExtensionRequestDto>>? GetExtensionRequest(Guid id);
    Task<ResponseResult<List<DocumentExtensionRequestDto>>>? GetExtensionRequestByEntityId(long EntityId);
    Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto request, Guid requestId, Guid managerId);
    Task<ResponseResult<List<ExtensionStatusHistoryDto>>> GetExtensionRequestHistory(Guid RequestId);
    Task<ResponseResult<ComplianceDetailsDto>>? CancelVisitByManager(CancelVisitDto Dto);
    Task<ResponseResult<ComplianceDetailsDto>>? RequestReschedule(RequestRescheduleDto rescheduleDto);
    Task<ResponseResult<ComplianceDetailsDto>>? ReviewRescheduleAsync(ReviewRescheduleDto reviewRescheduleDto);
    Task<ResponseResult<ComplianceDetailsDto>>? UpdateVisitStatus(UpdateVisitStatusDto statusDto);


    #region Figma Part 2 unmerged
    Task<ResponseResult<ComplianceDisclosureReportDto>> GetVisitDisclosureReportForComplianceManager(Guid visitId);
    Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForComplianceManager(Guid visitId, Guid visitSpecialistId);
    Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForLoggedInSpecialist(Guid visitId);
    Task<ResponseResult<bool>> SaveVisitDisclosureForm(ComplianceVisitDisclosureDto model);
    Task<ResponseResult<ComplianceVisitDisclosure>> GetComplianceVisitDisclosureBySpecialistId(Guid specialistid);
    Task<ResponseResult<List<CompliancePlanDto>>> GetVisitsByStatus(long visitStatusId);

    #endregion Figma Part 2 unmerged

    #endregion


}
