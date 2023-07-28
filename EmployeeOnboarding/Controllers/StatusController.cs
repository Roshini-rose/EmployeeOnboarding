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

        [HttpPost("approve")]
        public IActionResult ChangeApprovalStatus([FromBody] onboardstatusVM onboardstatus)
        {
            _onboardstatusService.ChangeApprovalStatus(onboardstatus);
            return Ok("Approved");
        }

        [HttpPost("reject")]
        public IActionResult ChangeCancelStatus([FromBody] onboardstatusVM onboardstatus)
        {
            _onboardstatusService.ChangeCancelStatus(onboardstatus);
            return Ok("Rejected");
        }

    }
}
