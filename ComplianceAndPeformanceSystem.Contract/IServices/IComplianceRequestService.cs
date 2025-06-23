using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Contract.Models.Compliance;
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

    #region  Phase2
    Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail(Guid id);
    Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null);
    Task<ResponseResult<bool>> AssignComplianceVisitSpecialist(AssignComplianceVisitSpecialistModel model);
    Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists();


    #region  part 03-05
    //Task<ResponseResult<bool>> AddVisitAttachment(List<IFormFile> attachmentvm, Guid ComplianceDetailsID);
    //Task<ResponseResult<ComplianceDetailsDto>>? GetComplianceVisitByComplianceDetailsID(Guid ComplianceDetailsID);
    //Task<ResponseResult<bool>> SendNotificationToLicensedEntityforUploadDocument(Guid ComplianceDetailsID, string senderName);

    //Task<ResponseResult<List<ComplianceDetailsDto>>> GetComplianceVisit();
    //Task<ResponseResult<DocumentExtensionRequestDto>>? AddExtensionRequest(DocumentExtensionRequestDto request, Guid ComplianceDetailsID);
    //Task<ResponseResult<DocumentExtensionRequestDto>>? GetExtensionRequest(Guid id);
    //Task<ResponseResult<List<DocumentExtensionRequestDto>>>? GetExtensionRequestByEntityId(long EntityId);
    //Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto request, Guid requestId, Guid managerId);
    //Task<ResponseResult<List<ExtensionStatusHistoryDto>>> GetExtensionRequestHistory(Guid RequestId);
    //Task<ResponseResult<ComplianceDetailsDto>>? CancelVisitByManager(CancelVisitDto Dto);
    //Task<ResponseResult<ComplianceDetailsDto>>? RequestReschedule(RequestRescheduleDto rescheduleDto);
    //Task<ResponseResult<ComplianceDetailsDto>>? ReviewReschedule(ReviewRescheduleDto reviewRescheduleDto);
    //Task<ResponseResult<ComplianceDetailsDto>>? UpdateVisitStatus(UpdateVisitStatusDto statusDto);


    Task<ResponseResult<bool>> AddVisitAttachment(List<IFormFile> attachmentvm, Guid ComplianceDetailsID);
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
    Task<ResponseResult<DocumentExtensionRequestDto>>? AddExtensionRequest(DocumentExtensionRequestDto request, Guid ComplianceDetailsID);
    Task<ResponseResult<DocumentExtensionRequestDto>>? GetExtensionRequest(Guid id);
    Task<ResponseResult<List<DocumentExtensionRequestDto>>>? GetExtensionRequestByEntityId(long EntityId);
    Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto request, Guid requestId, Guid managerId);
    Task<ResponseResult<List<ExtensionStatusHistoryDto>>> GetExtensionRequestHistory(Guid RequestId);
    Task<ResponseResult<ComplianceDetailsDto>>? CancelVisitByManager(CancelVisitDto Dto);
    Task<ResponseResult<ReviewRescheduleDto>>? RequestReschedule(RequestRescheduleDto rescheduleDto);
    Task<ResponseResult<List<ReviewRescheduleDto>>>? GetRescheduleRequests(long? LicensedID);
    Task<ResponseResult<ComplianceDetailsDto>>? ReviewReschedule(ReviewRescheduleDto reviewRescheduleDto);
    Task<ResponseResult<ComplianceDetailsDto>>? UpdateVisitStatus(UpdateVisitStatusDto statusDto);
    
    #endregion
    #endregion
}
