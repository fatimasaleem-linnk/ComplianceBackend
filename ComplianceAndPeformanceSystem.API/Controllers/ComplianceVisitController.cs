using ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;
using ComplianceAndPeformanceSystem.Contract.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> AddExtensionRequest(Guid complianceDetailsId, [FromBody] DocumentExtensionRequestDto request)
        {
            var result = await _requestService.AddExtensionRequest(request, complianceDetailsId);
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
        public async Task<IActionResult> GetExtensionRequestByEntityId([FromRoute] long entityId)
        {
            var result = await _requestService.GetExtensionRequestByEntityId(entityId);
            return Ok(result);
        }

        // 5. Update Extension Request (Review/Approve/Reject/Modify)
        [HttpPut]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> UpdateExtensionRequest([FromBody] DocumentExtensionReviewDto request, Guid requestId, Guid managerId)
        {
            var result = await _requestService.UpdateExtensionRequest(request, requestId, managerId);
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
        [HttpPut]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> CancelVisitByManager([FromBody] CancelVisitDto dto)
        {
            var result = await _requestService.CancelVisitByManager(dto);
            return Ok(result);
        }

        // 8. Request Reschedule (Entity/Specialist/Manager)
        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> RequestReschedule([FromBody] RequestRescheduleDto rescheduleDto)
        {
            var result = await _requestService.RequestReschedule(rescheduleDto);
            return Ok(result);
        }

        // 9. Review Reschedule Request (Manager/Specialist)
        [HttpPut]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ReviewReschedule([FromBody] ReviewRescheduleDto reviewRescheduleDto)
        {
            var result = await _requestService.ReviewReschedule(reviewRescheduleDto);
            return Ok(result);
        }

        // 10. Update Visit Status (e.g., Mark Completed)
        [HttpPut]
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
            if (attach == null || !attach.Any())
                return BadRequest("No Files Were Uploaded.");
            var result = await _requestService.AddVisitAttachment(attach,ComplianceDetailsID);
            if (!result.Succeeded)
                return BadRequest(result);

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
    }
}
