﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmployeeOnboarding.Contracts;
using EmployeeOnboarding.Repository;
using EmployeeOnboarding.Services;
using EmployeeOnboarding.ViewModels;
using EmployeeOnboarding.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeeOnboarding.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class StatusController : ControllerBase
    {

        public onboardstatusService _onboardstatusService;
        public ApplicationDbContext _context;

        public StatusController(onboardstatusService onboardstatusService, ApplicationDbContext context)
        {
            _onboardstatusService = onboardstatusService;
            _context = context;
        }

        [HttpPost("approve/{id}")]
        public IActionResult ChangeApprovalStatus(int id,[FromBody] onboardstatusVM onboardstatus)
        {
            _onboardstatusService.ChangeApprovalStatus(id,onboardstatus);
            return Ok("Approved");
        }

        [HttpPost("reject/{id}")]
        public IActionResult ChangeCancelStatus(int id, [FromBody] commentVM onboardstatus)
        {
            _onboardstatusService.ChangeCancelStatus(id,onboardstatus);
            return Ok("Rejected");
        }

        [HttpPost("pending/{id}")]
        public IActionResult ChangePendingStatus(int id)
        {
            _onboardstatusService.ChangePendingStatus(id);
            return Ok("Pending");
        }

        //[HttpGet("status-dashboard")]
        //public async Task<statusdashVM> GetAdminStatusList()
        //{
        //    var upstatus = await _context.Approvals.ToListAsync();
        //    var model = new statusdashVM
        //    {
        //        TotalRequests = upstatus.Count,
        //        ApprovedRequests = upstatus.Count(q => q.Approved == true),
        //        PendingRequests = leaveRequests.Count(q => q.Cancelled == null),
        //        RejectedRequests = upstatus.Count(q => q.Cancelled == true),
        //    };

        //    return model;
        //}
    }

}
