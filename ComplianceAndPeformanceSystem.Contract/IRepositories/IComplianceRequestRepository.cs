using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.Compliance;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Core.Entities;
using ComplianceAndPeformanceSystem.Core.Entities.ComplainceVisit;

namespace ComplianceAndPeformanceSystem.Contract.IRepositories;

public interface IComplianceRequestRepository
{
    Task CreateComplianceRequest();
    Task<ResponseResult<KeyValuePair<List<string>, List<string>>>> AssignComplianceSpecialist(AssignComplianceSpecialistModel model);
    Task UpdateRemainingDays();
    Task<ResponseResult<List<ComplianceNotificationMessageDto>>> GetComplianceNotifications(List<string> rolesName);
    Task<ResponseResult<ComplianceRequestDto>> GetComplianceRequest(ComplianceRequestFilterDto filter, bool isEmail = false);
    Task<ResponseResult<List<ComplianceActivityDto>>> GetComplianceActivities(Guid requestId);
    Task<ResponseResult<string>> GetComplianceApproval(Guid requestId);
    Task<ResponseResult<bool>> SaveCompliancePlan(CompliancePlanModel model);
    Task<ResponseResult<bool>> DeleteCompliancePlan(Guid planId);
    Task<ResponseResult<string>> SendComplianceRequest(Guid requestId);
    Task<ResponseResult<string>> SendComplianceApprovalToPerformanceMonitoringManager(Guid requestId);
    Task<ResponseResult<bool>> ApproveOrRejectComplianceRequest(ApproveOrRejectComplianceRequestModel model, ComplianceStatusEnum status);

    Task<ComplianceRequest> GetLatestComplianceRequest();
    Task<List<AttachmentDto>> GetVisitAttachments(List<Guid> visitIds);
    Task<List<LookupValue>> GetLookupValues();

    bool GetComplianceVisitDisclosure(Guid ComplianceVisitSpecialistId);

    #region phase2
    Task<ResponseResult<CompliancePlanDto>> GetComplianceVisitDetail(Guid id);
    Task<ResponseResult<bool>> SaveComplianceVisit(ComplianceVisitModel model, long? VisitStatusId = null);
    Task<ResponseResult<List<CompliancePlanDto>>> GetVisitsByStatusForLoggedInUser(string LoggedInUserId, long visitStatusId);
    Task<List<CompliancePlanDto>> GetUnscheduledVisitsForCurrentQuarter();
    Task<List<CompliancePlanDto>> GetNewVisitsForCurrentQuarter();
    Task<ResponseResult<List<ComplianceVisitSpecialistModel>>> GetComplianceVisitSpecialists(Guid complianceDetailId);
    Task<ResponseResult<AssignComplianceVisitSpecialistResponseModel>> AssignComplianceVisitSpecialists(AssignComplianceVisitSpecialistModel model);
    Task<ResponseResult<List<ComplianceSpecialistDto>>> GetComplianceRequestSpecialists(Guid visitId);


    Task<TeamShortage> AddTeamShortage(TeamShortage request);
    Task<List<TeamShortage>> GetTeamShortageByVisitId(List<Guid> ComplianceDetailsIds);

    #region Part 03
    Task<ResponseResult<List<ComplianceDetailsDto>>> GetComplianceVisit();
    Task<ResponseResult<DocumentExtensionRequestDto>>? AddExtensionRequest(ExtensionRequestModel request);
    Task<ResponseResult<DocumentExtensionRequestDto>>? GetExtensionRequest(Guid id);
    Task<ResponseResult<List<DocumentExtensionRequestDto>>> ExtensionRequests();
    Task<ResponseResult<List<DocumentExtensionRequestDto>>>? GetExtensionRequestByEntityId(long EntityId);
    Task<ResponseResult<DocumentExtensionReviewDto>> UpdateExtensionRequest(DocumentExtensionReviewDto request);
    Task<ResponseResult<List<ExtensionStatusHistoryDto>>> GetExtensionRequestHistory(Guid RequestId);
    Task<ResponseResult<bool>>? CancelVisitByManager(CancelVisitDto Dto);

    Task<ResponseResult<SpecialistRescheduleDto>> SpecialistReschedule(RequestRescheduleDto rescheduleDto);
    Task<ResponseResult<RequestRescheduleDto>>? RequestReschedule(RequestRescheduleDto rescheduleDto);
    Task<ResponseResult<List<RequestRescheduleDto>>> GetRescheduleRequestsForManager();
    Task<ResponseResult<RequestRescheduleDto>>? ReviewRescheduleAsync(ReviewRescheduleDto reviewRescheduleDto);

    Task<ResponseResult<List<RequestRescheduleDto>>>? GetRescheduleRequests(long? LicensedID);
    Task<ResponseResult<ComplianceDetailsDto>>? UpdateVisitStatus(UpdateVisitStatusDto statusDto);
    #endregion

    #region Figma Part 2 unmerged
    Task<ResponseResult<ComplianceDisclosureReportDto>> GetVisitDisclosureReportForComplianceManager(Guid visitId);
    Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForComplianceManager(Guid visitId, string visitSpecialistId);
    Task<ResponseResult<ComplianceVisitDisclosureDto>> GetVisitDisclosureFormForLoggedInSpecialist(Guid visitId);
    Task<ResponseResult<bool>> SaveVisitDisclosureForm(ComplianceVisitDisclosureDto model);
    Task<ResponseResult<ComplianceVisitDisclosure>> GetComplianceVisitDisclosureBySpecialistId(Guid specialistid);
    Task<ResponseResult<List<CompliancePlanDto>>> GetVisitsByStatus(long visitStatusId);

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


    Task<ResponseResult<Guid>> SaveComplianceReportActivity(ReportRequestActivityModel model);
    Task<ResponseResult<ReportRequestActivityDto>> GetComplianceReportActivity(Guid id);
    Task<ResponseResult<List<ReportRequestActivityDto>>> GetComplianceReportActivities(bool isReply);



    // phase 8 & 9 
    Task<CorrectiveActionPlan> AddCorrectPlan(CorrectiveActionPlanDto dto);
    Task<CorrectiveEvidence> UploadEvidence(EvidenceUploadDto dto);
    Task<CorrectiveActionPlanDto?> GetPlanWithAttachments(Guid VisitId);
    Task ReviewEvidence(EvidenceReviewDto dto);
    Task ReviewReport(ComplianceReportReviewDto dto);
    Task<ResponseResult<string>> ReturnLicenseNumber(long LicenseEntityID);
    #endregion
}
