using ComplianceAndPeformanceSystem.Contract.Dtos;
using ComplianceAndPeformanceSystem.Contract.Dtos.ComplianceVisit;
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
    public class ComplianceRequestController(IComplianceRequestService requestService) : ControllerBase
    {
        #region Phase 1

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetNotifications()
        {
            return Ok(await requestService.GetNotifications());
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceRequestStatus()
        {
            return Ok(await requestService.GetComplianceRequestStatus());
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceRequest()
        {
            var result = await requestService.GetComplianceRequest(null);
            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceSpecialist()
        {
            return Ok(await requestService.GetComplianceSpecialist());
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> AssignComplianceSpecialist(AssignComplianceSpecialistModel model)
        {
            return Ok(await requestService.AssignComplianceSpecialist(model));
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> SaveCompliancePlan(CompliancePlanModel model)
        {
            return Ok(await requestService.SaveCompliancePlan(model));
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> DeleteCompliancePlan(Guid planId)
        {
            return Ok(await requestService.DeleteCompliancePlan(planId));
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceActivities(Guid requestId)
        {
            return Ok(await requestService.GetComplianceActivities(requestId));
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> SendComplianceRequest(Guid requestId)
        {
            return Ok(await requestService.SendComplianceRequest(requestId));
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ApproveComplianceRequestByComplianceManager(Guid requestId)
        {
            return Ok(await requestService.ApproveComplianceRequestByComplianceManager(new ApproveOrRejectComplianceRequestModel() { RequestId = requestId, IsApproved = true }));
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ReturnComplianceRequestByComplianceManager(ApproveOrRejectComplianceRequestModel model)
        {
            return Ok(await requestService.ReturnComplianceRequestByComplianceManager(model));
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ApproveComplianceRequestByPerformanceMonitoringManager(Guid requestId)
        {
            return Ok(await requestService.ApproveComplianceRequestByPerformanceMonitoringManager(new ApproveOrRejectComplianceRequestModel() { RequestId = requestId, IsApproved = true }));
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> ReturnComplianceRequestByPerformanceMonitoringManager(ApproveOrRejectComplianceRequestModel model)
        {
            return Ok(await requestService.ReturnComplianceRequestByPerformanceMonitoringManager(model));
        }
        #endregion

        #region Phase 2
        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceVisitDetail(Guid id)
        {
            return Ok(await requestService.GetComplianceVisitDetail(id));
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> SaveComplianceVisit(ComplianceVisitModel model)
        {
            var result = await requestService.SaveComplianceVisit(model);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> RescheduleComplianceVisit(ComplianceVisitModel model)
        {
            var result = await requestService.SaveComplianceVisit(model, (long)VisitStatusEnum.Rescheduled);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceRequestSpecialists(Guid visitId)
        {
            return Ok(await requestService.GetComplianceRequestSpecialists(visitId));
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> AssignComplianceVisitSpecialists(AssignComplianceVisitSpecialistModel model)
        {
            var result = await requestService.AssignComplianceVisitSpecialists(model);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok(result);
        }

        #region Figma part 2 unmerged

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetVisitDisclosureReportForComplianceManager(Guid visitId)
        {
            return Ok(await requestService.GetVisitDisclosureReportForComplianceManager(visitId));
        }


        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetVisitDisclosureFormForComplianceManager(Guid visitId, string visitSpecialistId)
        {
            return Ok(await requestService.GetVisitDisclosureFormForComplianceManager(visitId, visitSpecialistId));
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetVisitDisclosureFormForLoggedInSpecialist(Guid visitId)
        {
            return Ok(await requestService.GetVisitDisclosureFormForLoggedInSpecialist(visitId));
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> SaveVisitDisclosureForm(ComplianceVisitDisclosureDto model)
        {
            var result = await requestService.SaveVisitDisclosureForm(model);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> SubmitTeamShortageRequest([FromBody] TeamShortageDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await requestService.SubmitTeamShortageRequest(dto);
            return Ok(new { message = "تم إرسال طلب معالجة نقص الفريق بنجاح", data = result });
        }

        #endregion Figma Part 2 unmerged

        #endregion


    }
}
