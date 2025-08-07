using ComplianceAndPeformanceSystem.Contract.Enums;
using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComplianceAndPeformanceSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class TemplateController(ITemplateService templateService) : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> SaveTemplate(TemplateModel model)
        {
            return Ok(await templateService.SaveTemplate(model));
        }

        [HttpGet]
        public async Task<IActionResult> GetTemplates(TemplateTypeEnum type)
        {
            return Ok(await templateService.GetTemplates(type));
        }

    }
}
