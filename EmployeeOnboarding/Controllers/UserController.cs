using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using EmployeeOnboarding.Data.Services;
//using EmployeeOnboarding.Models;
using EmployeeOnboarding.ViewModels;
using OnboardingWebsite.Models;
using EmployeeOnboarding.Services;
//using EmployeeOnboarding.Services;

namespace EmployeeOnboarding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly EducationService _educationService;
        private readonly WorkExperienceService _experienceService; // Corrected the type here.

        public UserController(EducationService educationService, WorkExperienceService experienceService)
        {
            _educationService = educationService;
            _experienceService = experienceService;
        }


        [HttpPost("add-UG-education/{empId}")]
        public async Task<IActionResult> AddEducationUG(int empId, [FromForm] EducationVM education)
        {
            _educationService.AddEducationUG(empId, education);
            return Ok();
        }



        [HttpPost("add-PG-education/{empId}")]
        public async Task<IActionResult> AddEducationPG(int empId, [FromForm] EducationVM education)
        {
            _educationService.AddEducationPG(empId, education);
            return Ok();
        }



        [HttpPost("add-experience/{empId}")]
        public async Task<IActionResult> AddExperience(int empId, [FromForm] WorkExperienceVM experience)
        {
            _experienceService.AddExperiences(empId, experience);
            return Ok();
        }


        [HttpGet("get-UG-education/{id}")]
        public IActionResult GetEducationUG(int id)
        {
            var education = _educationService.GetEducationUG(id);
            return Ok(education);
        }



        [HttpGet("get-PG-education/{id}")]
        public IActionResult GetEducationPG(int id)
        {
            var education = _educationService.GetEducationPG(id);
            return Ok(education);
        }


        [HttpGet("get-experience/{id}")]
        public IActionResult GetExperience(int id)
        {
            var experience = _experienceService.GetExperience(id);
            return Ok(experience);
        }
    }
}