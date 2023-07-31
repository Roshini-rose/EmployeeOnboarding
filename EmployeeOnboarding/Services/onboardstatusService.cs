using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EmployeeOnboarding.Data;
using EmployeeOnboarding.ViewModels;

namespace EmployeeOnboarding.Services
{
    public class onboardstatusService
    {
        private ApplicationDbContext _context;
        public onboardstatusService(ApplicationDbContext context) 
        {
            _context= context;
        }
        public void ChangeApprovalStatus(onboardstatusVM onboard)
        {
            var _onboard = new ApprovalStatus()
            {
                Empid = onboard.Empid,
                Empname = onboard.Empname,
                Approved = true,
                Cancelled = false,
                Date_Created= DateTime.UtcNow,
                Date_Modified= DateTime.UtcNow,
                Created_by=onboard.Empname,    
                Modified_by=onboard.Empname,
                Status="Active",
            };
            _context.Approvals.Add(_onboard);
            _context.SaveChanges();
        }

        //change
        public void ChangeCancelStatus(onboardstatusVM onboard)
        {
            var _onboard = new ApprovalStatus()
            {
                Empid = onboard.Empid,
                Empname = onboard.Empname,
                Approved = false,
                Cancelled = true,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = onboard.Empname,
                Modified_by = onboard.Empname,
                Status = "Active",
            };
            _context.Approvals.Add(_onboard);
            _context.SaveChanges();
        }

    }
}
