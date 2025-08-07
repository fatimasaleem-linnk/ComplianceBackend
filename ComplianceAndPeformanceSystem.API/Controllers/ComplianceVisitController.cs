using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace ComplianceAndPeformanceSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ComplianceVisitController(IComplianceRequestService _requestService) : ControllerBase
    {
        // 1. Get all Compliance Visits
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceVisits()
        {
            var result = await _requestService.GetComplianceVisit();
            return Ok(result);
        }
        
        // 2. Add Document Extension Request
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> AddExtensionRequest([FromBody] ExtensionRequestModel request)
        {
            var result = await _requestService.AddExtensionRequest(request);
            return Ok(result);
        }

        // 3. Get Document Extension Request by Id
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetExtensionRequest(Guid id)
        {
            var result = await _requestService.GetExtensionRequest(id);
            return Ok(result);
        }

        // 4. Get Extension Requests by Entity Id
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetExtensionRequestByEntityId(long entityId)
        {
            var result = await _requestService.GetExtensionRequestByEntityId(entityId);
            return Ok(result);
        }

        // 5. Update Extension Request (Review/Approve/Reject/Modify)
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> UpdateExtensionRequest([FromBody] DocumentExtensionReviewDto request)
        {
            var result = await _requestService.UpdateExtensionRequest(request);
            return Ok(result);
        }

        // 6. Get Extension Request History
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetExtensionRequestHistory(Guid requestId)
        {
            var result = await _requestService.GetExtensionRequestHistory(requestId);
            return Ok(result);
        }

        // 7. Cancel Visit by Manager
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> CancelVisitByManager([FromBody] CancelVisitDto dto)
        {
            var result = await _requestService.CancelVisitByManager(dto);
            return Ok(result);
        }

        // 8. Request Reschedule (Entity/Specialist/Manager)
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> EntityRequestReschedule([FromBody] RequestRescheduleDto rescheduleDto)
        {
            var result = await _requestService.RequestReschedule(rescheduleDto);
            return Ok(result);
        }

        // 9. Review Reschedule Request (Manager/Specialist)
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ReviewReschedule([FromBody] ReviewRescheduleDto reviewRescheduleDto)
        {
            var result = await _requestService.ReviewReschedule(reviewRescheduleDto);
            return Ok(result);
        }

        // 10. Update Visit Status (e.g., Mark Completed)
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> UpdateVisitStatus([FromBody] UpdateVisitStatusDto statusDto)
        {
            var result = await _requestService.UpdateVisitStatus(statusDto);
            return Ok(result);
        }

        // 11. Get GetRescheduleRequests
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetRescheduleRequests(long? entityId)
        {
            var result = await _requestService.GetRescheduleRequests(entityId);
            return Ok(result);
        }

        // 12. AddVisitAttachment

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> AddVisitAttachment([FromForm] List<IFormFile> attach, [FromForm] Guid ComplianceDetailsID)
        {
            if (attach == null || attach.Count == 0)
                return BadRequest("No Files Were Uploaded.");
            var result = await _requestService.AddVisitAttachment(attach, ComplianceDetailsID);
            if (!result.Succeeded)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> DownloadAttachmentForAttachmentId(Guid attachmentId)
        {
            var result = await _requestService.DownloadAttachmentForAttachmentId(attachmentId);
            return Ok(result);
        }
        // 13. Get Document Extension Request by Id
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ExtensionRequests()
        {
            var result = await _requestService.ExtensionRequests();
            return Ok(result);
        }

        // 14. Complaince Manger Reschedule Visit
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ComplainceMangerReschedule([FromBody] RequestRescheduleDto rescheduleDto)
        {
            var result = await _requestService.SpecialistReschedule(rescheduleDto);
            return Ok(result);
        }

        // 15. Get all schedule Compliance Visits for entity
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetScheduleVisitsForEntity(long entityId)
        {
            long? Scheduled = (long?)VisitStatusEnum.Scheduled;
            long? Rescheduled = (long?)VisitStatusEnum.Rescheduled;

            var result = await _requestService.GetComplianceVisit();
            var visit = result.Model?.Where(a => a.LicensedEntityId == entityId && a.VisitStatusId == Scheduled || a.VisitStatusId == Rescheduled).ToList();
            return Ok(visit);
        }

        // 16. Get Complaince Visits For Specialist
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplainceVisitsForSpecialist(string? SpecialistID, long? VisitTypeID, long? VisitStatusID, long? LicenseeEntityID, string? VisitReferanceNumber, DateTime? VisitDate)
        {
            ComplianceRequestFilterDto filter = new()
            {
                VisitTypeID = VisitTypeID,
                VisitStatusID = VisitStatusID,
                LicenseeEntityID = LicenseeEntityID,
                VisitReferanceNumber = VisitReferanceNumber,
                VisitDate = VisitDate
            };

            var result = await _requestService.GetComplianceforSpecilest(filter);

            var visit = result.Model?.CompliancePlans?.Where(a => a.ComplianceVisitSpecialists != null && a.ComplianceVisitSpecialists.Any(a => a.SpecialistUserId == SpecialistID)).ToList();

            if (SpecialistID != null)
                return Ok(visit);
            else
                return Ok(result);
        }


        /// <summary>
        /// </summary>
        /// <param name="Patch-Tow"></param>
        /// <returns></returns>

        // 17. Add Compliance Report Form 
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> AddComplianceReport([FromForm] ComplianceReportDto reportDto)
        {
            var result = await _requestService.AddComplianceReport(reportDto);
            return Ok(result);
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> SaveComplianceReportActivity([FromForm] ReportRequestActivityModel model)
        {
            var result = await _requestService.SaveComplianceReportActivity(model);
            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceReportActivity(Guid id)
        {
            var result = await _requestService.GetComplianceReportActivity(id);
            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceReportActivities(bool isReply)
        {
            var result = await _requestService.GetComplianceReportActivities(isReply);
            return Ok(result);
        }

        // 18. Get Compliance Report
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceReport(Guid ReportID)
        {
            var result = await _requestService.GetComplianceReport(ReportID);
            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetAllComplianceReports()
        {
            var result = await _requestService.GetAllComplianceReports();
            return Ok(result);
        }

        // 19. Get Report Category
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetReportStructure()
        {
            var result = await _requestService.GetReportStructureDto();
            return Ok(result);
        } 
        // 28. Get Report Category
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetReportCategory()
        {
            var result = await _requestService.GetCategory();
            return Ok(result);
        }
        // 20. Get Report Sub Category
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetSubCategory(int CategoryId)
        {
            var result = await _requestService.GetSubCategory(CategoryId);
            return Ok(result);
        }
        // 21.  Get Entries Report 
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetEntries(int SubCategoryId)
        {
            var result = await _requestService.GetEntries(SubCategoryId);
            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetRescheduleRequestsForManager()
        {
            var result = await _requestService.GetRescheduleRequestsForManager();
            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetCorrectPlanById(Guid planId)
        {
            var result = await _requestService.GetCorrectPlanById(planId);
            if (result == null)
                return NotFound("Plan not found");
            return Ok(result);
        }
        
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ReturnLicenseNumber(long LicenseEntityID)
        {
            var result = await _requestService.ReturnLicenseNumber(LicenseEntityID);
            if (result == null)
                return NotFound("not found");
            return Ok(result);
        }
        
        [NonAction]
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> UploadEvidence( EvidenceUploadDto dto)
        {
            var result = await _requestService.UploadEvidence(dto);
            return Ok(result);
        }
       
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ReviewEvidence(EvidenceReviewDto dto)
        {
            await _requestService.ReviewEvidence(dto);
            return Ok();
        }
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ReviewReport(ComplianceReportReviewDto dto)
        {
            await _requestService.ReviewReport(dto);
            return Ok();
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> CreateCorrectPlan(CorrectiveActionPlanDto dto)
        {
            var result = await _requestService.AddCorrectPlan(dto);
            return Ok(new { message = "تم إرسال الخطة التصحيحية بنجاح", data = result});
        }
    }
}
