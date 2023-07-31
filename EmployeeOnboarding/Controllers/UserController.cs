using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using EmployeeOnboarding.Data.Services;
using EmployeeOnboarding.Models;

namespace EmployeeOnboarding.Controllers
{   /// <summary>
/// 
/// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public EducationService _educationService;
        public UserController(EducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpPost("add-UG-education/{empId}")]
        public async Task<IActionResult> AddEducationUG(string empId, [FromForm] EducationVM education)
        {
            _educationService.AddEducationUG(empId, education);
            return Ok();
        }

        [HttpPost("add-PG-education/{empId}")]
        public async Task<IActionResult> AddEducationPG(string empId, [FromForm] EducationVM education)
        {
            _educationService.AddEducationPG(empId, education);
            return Ok();
        }
        

        [HttpGet("get-UG-education/{id}")]
        public IActionResult GetEducationUG(string id)
        {
            var education = _educationService.GetEducationUG(id);
            return Ok(education);
        }

        [HttpGet("get-PG-education/{id}")]
        public IActionResult GetEducationPG(string id)
        {
            var education = _educationService.GetEducationPG(id);
            return Ok(education);
        }
    }
}
