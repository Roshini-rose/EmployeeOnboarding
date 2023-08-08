using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeOnboarding.Contracts;
using EmployeeOnboarding.Services;
using EmployeeOnboarding.ViewModels;

namespace EmployeeOnboarding.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class logindetailsController : ControllerBase
    {

        public logindetailsService _logindetailsService;
        private readonly ILogin _loginemp;

        public logindetailsController(ILogin loginemp, logindetailsService logindetailsService)
        {
            _logindetailsService = logindetailsService;
            _loginemp = loginemp;
        }

        [HttpPost("Login-Invite")]
        public IActionResult LoginDetails([FromBody] logininviteVM logindetails)
        {
            _logindetailsService.LoginInvite(logindetails);
            return Ok("Invite Sent");
        }

        //[HttpPost("Login-In")]
        //public async Task<IActionResult> LoginDetail(string name, string email)
        //{
        //  await _logindetailsService.LoginIn(name,email);
        //    return Ok("Invite");
        //}

        [HttpPost("confirm-login")]
        public IActionResult CLogins(string email, [FromBody] loginconfirmVM logindetails)
        {
            var issuccess = _logindetailsService.LoginCmp(email, logindetails);

            if (issuccess.Result != null)
            {
                return Ok("Confirmed");
            }
            else
            {
                return Ok("Invaild");
            }
        }

        [HttpPost("conf-login")]
        public IActionResult CLogins(string email, [FromBody] loginconfirmVM logindetails)
        {
            var issuccess = _loginemp.AuthenticateEmp(email, password);

            if (issuccess != null)
            {
                return Ok(issuccess);
            }
            else
            {
                return Ok("Invaild");
            }
        }

        [HttpPost("admin-login")]
        public IActionResult AdminLogin(string email, string password)
        {

            if (email == "admin@ideassion.com" && password == "admin123")
            {
                return Ok("Admin Logged in");
            }
            else
            {
                return Ok("Not Admin");
            }
        }
    }

}
