using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.Compliance;
using ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Core.Entities;
using Microsoft.AspNetCore.Http;

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
    Task<ResponseResult<ComplianceRequestDto>> GetComplianceRequest(ComplianceRequestFilterDto filter);
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
    Task<ResponseResult<List<RequestRescheduleDto>>> GetRescheduleRequestsForManager();

    Task<ResponseResult<ComplianceRequestDto>> GetComplianceforSpecilest(ComplianceRequestFilterDto? filter);
    #region  Phase2
    Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail(Guid id);
    Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null);
    Task<ResponseResult<bool>> AssignComplianceVisitSpecialists(AssignComplianceVisitSpecialistModel model);
    Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists(Guid visitId);

    Task<TeamShortageDto> SubmitTeamShortageRequest(TeamShortageDto dto);
    Task<List<TeamShortageDto>> GetByComplianceDetailsIds(List<Guid> complianceDetailsIds);
    Task SendNotifycationToManagerForTeamShortage(List<Guid> VisitDeatilasID);
    Task SendSmsToSpecialistForTeamShortage(List<Guid> VisitDeatilasID);

    #region  part 03-05
    Task<ResponseResult<bool>> AddVisitAttachment(List<IFormFile> visitAttachment, Guid complianceDetailsId);
    Task<AttachmentDto> DownloadAttachmentForAttachmentId(Guid attachmentId);
    Task<ResponseResult<ComplianceDetailsDto>>? GetComplianceVisitByComplianceDetailsID(Guid ComplianceDetailsID);
    Task<ResponseResult<bool>> SendNotificationToLicensedEntityforUploadDocument(Guid ComplianceDetailsID, string senderName);
    Task SendSMSUploadAttachmentSecsessed(Guid ComplianceDetailsID);
    Task SendNotificationToComplianceManagerforNoDocumentsSubmitted();
    Task SendSMSToComplianceManagerforNoDocumentsSubmitted(Guid ComplianceDetailsID);

    // Extension Request 
    Task SendNotificationToEntityforExtensionRequestApproved(Guid RequestID);
    Task SendNotifycationToEntityforExtensionRequestSubmitted(Guid RequestID);
    Task SendNotifycationToEntityforExtensionRequestRejection(Guid RequestID);

    Task SendNotificationToManagerRequestApproved(Guid RequestID);
    Task SendNotifycationToManagerRequestSubmitted(Guid RequestID);
    Task SendNotifycationToEntityforManagerRequestPinding(Guid RequestID);
    Task SendSMSToEntityForCancelVisit(Guid ComplianceDetailsID);
    Task<ResponseResult<bool>> SendNotificationToEntityForCancelVisit(Guid ComplianceDetailsID);

    Task SendSMSToEntityForRequestRescheduleVisit(int RequestId, long LicenseID);
    Task<ResponseResult<bool>> SendNotificationToEntityForRequestRescheduleVisit(int RequestId, long LicenseID);

    Task<ResponseResult<List<ComplianceDetailsDto>>> GetComplianceVisit();
    Task<ResponseResult<DocumentExtensionRequestDto>>? AddExtensionRequest(ExtensionRequestModel request);
    Task<ResponseResult<DocumentExtensionRequestDto>>? GetExtensionRequest(Guid id);
    Task<ResponseResult<List<DocumentExtensionRequestDto>>> ExtensionRequests();
    Task<ResponseResult<List<DocumentExtensionRequestDto>>>? GetExtensionRequestByEntityId(long EntityId);
    Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto request);
    Task<ResponseResult<List<ExtensionStatusHistoryDto>>> GetExtensionRequestHistory(Guid RequestId);
    Task<ResponseResult<bool>>? CancelVisitByManager(CancelVisitDto Dto);
    Task<ResponseResult<RequestRescheduleDto>>? RequestReschedule(RequestRescheduleDto rescheduleDto);
    Task<ResponseResult<SpecialistRescheduleDto>> SpecialistReschedule(RequestRescheduleDto dto);
    Task<ResponseResult<List<RequestRescheduleDto>>>? GetRescheduleRequests(long? LicensedID);
    Task<ResponseResult<RequestRescheduleDto>>? ReviewReschedule(ReviewRescheduleDto reviewRescheduleDto);
    Task<ResponseResult<ComplianceDetailsDto>>? UpdateVisitStatus(UpdateVisitStatusDto statusDto);

    #endregion

    #region Figma Part 2 unmerged
    Task<ResponseResult<ComplianceDisclosureReportDto>> GetVisitDisclosureReportForComplianceManager(Guid visitId);
    Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForComplianceManager(Guid visitId, string visitSpecialistId);
    Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForLoggedInSpecialist(Guid visitId);
    Task<ResponseResult<bool>> SaveVisitDisclosureForm(ComplianceVisitDisclosureDto model);

    Task SendVisitDisclosureNotSubmittedNotificationAsync();

    #endregion Figma Part 2 unmerged
    #endregion

    #region Complaince Report 
    Task<List<ReportCategoryDto>> GetReportStructureDto();
    Task<List<ReportCategory>> GetCategory();
    Task<List<ReportSubCategory>> GetSubCategory(int? CategoryID);
    Task<List<ReportEntries>> GetEntries(int? SubCategoryID);
    Task<ResponseResult<ComplianceReportDto>> AddComplianceReport(ComplianceReportDto reportDto);
    Task<ResponseResult<ComplianceReportDto>> GetComplianceReport(Guid? id);
    Task<ResponseResult<List<ComplianceReportDto>>> GetAllComplianceReports();


    Task<CorrectiveActionPlan> AddCorrectPlan(CorrectiveActionPlanDto dto);
    Task<CorrectiveEvidence> UploadEvidence(EvidenceUploadDto dto);
    Task<CorrectiveActionPlanDto?> GetCorrectPlanById(Guid VisitId);
    Task ReviewEvidence(EvidenceReviewDto dto);
    Task ReviewReport(ComplianceReportReviewDto dto);


    Task<ResponseResult<bool>> SaveComplianceReportActivity(ReportRequestActivityModel model);
    Task<ResponseResult<ReportRequestActivityDto>> GetComplianceReportActivity(Guid id);
    Task<ResponseResult<List<ReportRequestActivityDto>>> GetComplianceReportActivities(bool isReply);
    Task<ResponseResult<string>> ReturnLicenseNumber(long LicenseEntityID);
    #endregion
}
