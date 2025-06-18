using ComplianceAndPeformanceSystem.Contract.Common.Models;
using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using ComplianceAndPeformanceSystem.Contract.Models.Compliance;
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
            return Ok(await requestService.GetComplianceRequest());
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
            var result = await requestService.SaveComplianceVisit(model, (long) VisitStatusEnum.Rescheduled);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok(result);
        }

        [HttpGet]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> GetComplianceRequestSpecialist()
        {
            return Ok(await requestService.GetComplianceRequestSpecialists());
        }

        [HttpPost]
        [EnableRateLimiting("fixed")]
        public async Task<IActionResult> AssignComplianceVisitSpecialist(AssignComplianceVisitSpecialistModel model)
        {
            var result = await requestService.AssignComplianceVisitSpecialist(model);

            if (!result.Succeeded)
                return BadRequest(result);

            return Ok(result);
        }

        #endregion


    }
}
