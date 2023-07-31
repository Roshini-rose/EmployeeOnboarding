using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeOnboarding.Contracts;
using EmployeeOnboarding.Repository;
using EmployeeOnboarding.Services;
using EmployeeOnboarding.ViewModels;

namespace EmployeeOnboarding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StatusController : ControllerBase
    {
       
        public onboardstatusService _onboardstatusService;

        public StatusController(onboardstatusService onboardstatusService)
        {
            _onboardstatusService=onboardstatusService;
        }

        [HttpPost("approve/{id}")]
        public IActionResult ChangeApprovalStatus(string id)
        {
            _onboardstatusService.ChangeApprovalStatus(id);
            return Ok("Approved");
        }

        [HttpPost("reject/{id}")]
        public IActionResult ChangeCancelStatus(string id)
        {
            _onboardstatusService.ChangeCancelStatus(id);
            return Ok("Rejected");
        }

    }
}
