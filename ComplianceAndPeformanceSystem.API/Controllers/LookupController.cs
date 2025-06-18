using ComplianceAndPeformanceSystem.Contract.IServices;
using ComplianceAndPeformanceSystem.Contract.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ComplianceAndPeformanceSystem.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class LookupController(ILookupService lookupService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetLookupValueByCategoryID(long categoryId)
        {
            return Ok(await lookupService.GetLookupValue(new LookupQueryModel() { CategoryId = new List<long> { categoryId } }));
        }

        [HttpGet]
        public async Task<IActionResult> GetCategoryLookup()
        {
            return Ok(await lookupService.GetCategoryLookup());
        }

    }
}
