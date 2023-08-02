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
        public void ChangeApprovalStatus(string Empid)
        {
            var _onboard = new ApporvalStatus()
            {
                Empid = Empid,
                Approved = true,
                Cancelled = false,
                Date_Created= DateTime.UtcNow,
                Date_Modified= DateTime.UtcNow,
                Created_by="Admin",
                Modified_by="Admin",
                Status="Active",
            };
            _context.Approvals.Add(_onboard);
            _context.SaveChanges();
        }

        public void ChangeCancelStatus(string Empid)
        {
            var _onboard = new ApporvalStatus()
            {
                Empid = Empid,
                Approved = false,
                Cancelled = true,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = "Admin",
                Modified_by = "Admin",
                Status = "Active",
            };
            _context.Approvals.Add(_onboard);
            _context.SaveChanges();
        }
       


    }
}
