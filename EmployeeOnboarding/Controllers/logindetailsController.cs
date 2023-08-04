﻿using Microsoft.AspNetCore.Http;
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

        [HttpPost("add-userLoginInvite")]
        public IActionResult LoginDetails([FromBody] logininviteVM logindetails)
        {
            _logindetailsService.LoginInvite(logindetails);
            return Ok("Invite Sent");
        }

        [HttpPost("employee-login")]
        public IActionResult Logins(string email, string password)
        {
            var issuccess = _loginemp.AuthenticateEmp(email, password);


            if (issuccess.Result != null)
            {
                return Ok("Logged in");
            }
            else
            {
                return Ok("Invaild");
            }
        }

        [HttpPost("admin-login")]
        public IActionResult AdminLogins(string email, string password)
        {

            if (email=="admin@ideassion.com" && password =="admin123")
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
