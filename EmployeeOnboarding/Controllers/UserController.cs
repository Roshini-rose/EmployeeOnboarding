using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using EmployeeOnboarding.Data.Services;
using EmployeeOnboarding.Models;
using EmployeeOnboarding.ViewModels;
using EmployeeOnboarding.Services;

namespace EmployeeOnboarding.Controllers
{   /// <summary>
/// 
/// </summary>
/// 
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public EducationService _educationService;
        public WorkExperienceService _experienceService;
        public UserController(EducationService educationService, WorkExperienceService experienceService)
        {
            _educationService = educationService;
            _experienceService = experienceService;
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

        [HttpPost("add-experience/{empId}")]
        public async Task<IActionResult> AddExperience(string empId, [FromForm] WorkExperienceVM experience)
        {
            _experienceService.AddExperience(empId, experience);
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

        [HttpGet("get-experience/{id}")]
        public IActionResult GetExperience(string id)
        {
            var experience = _experienceService.GetExperience(id);
            return Ok(experience);
        }
    }
}
