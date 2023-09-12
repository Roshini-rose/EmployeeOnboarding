using EmployeeOnboarding.Data;
using EmployeeOnboarding.Services;
using EmployeeOnboarding.ViewModels;
using Microsoft.AspNetCore.Mvc;
using OnboardingWebsite.Models;
//using OnboardingWebsite.Models;

namespace EmployeeOnboarding.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        private readonly GeneralDetailService _generalservices;
        private readonly HobbyMembershipService _hobbyService;
        private readonly RequiredService _requiredService;
        private readonly EmergencyContactService _emergencyServices;

        public UserDetailsController(GeneralDetailService generalservices,HobbyMembershipService hobbyService, RequiredService requiredService, EmergencyContactService emergencyContactService)
        {
            _generalservices = generalservices;
            _requiredService = requiredService;
            _emergencyServices = emergencyContactService;
            _hobbyService = hobbyService;
        }


        //General details
        //post method

        [HttpPost("add-general-details/{Id}")]
        public IActionResult AddGeneral(int Id, [FromForm] GeneralVM general)
        {
            _generalservices.AddGeneral(Id, general);
            return Ok();
        }

        [HttpPost("add-hobby-details/{Id}")]
        public IActionResult AddHobby(int Id, [FromForm] HobbyVM hobby)
        {
            _hobbyService.AddHobby(Id, hobby);
            return Ok();
        }


        [HttpPost("add-emergency/{empId}")]
        public async Task<IActionResult> AddEmergencyContact(int empId, [FromBody] List<EmergencyContactVM> emergencies)
        {
            var data =_emergencyServices.AddEmergencyContact(empId, emergencies);
            return Ok(data + "Sucess");
        }


        [HttpPost("add-required-details/{Id}")]
        public IActionResult AddRequired(int Id, [FromForm] RequiredVM required)
        {
            _requiredService.AddRequired(Id, required);
            return Ok();
        }


        //get method

        [HttpGet("get-general-details/{Id}")]
        public IActionResult GetGeneral(int Id)
        {
            var generaldetails = _generalservices.GetGeneral(Id);
            return Ok(generaldetails);
        }

        [HttpGet("get-hobby-details/{Id}")]
        public IActionResult GetHobby(int Id)
        {
            var hobby = _hobbyService.GetHobby(Id);
            return Ok(hobby);
        }

        [HttpGet("get-emergency/{empId}")]
        public IActionResult GetEmergencyContact(int empId)
        {
            var education = _emergencyServices.GetEmergencyContact(empId);
            return Ok(education);
        }

    }

}

