using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using EmployeeOnboarding.Data;
using EmployeeOnboarding.ViewModels;
using EmployeeOnboarding.Data.Enum;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeOnboarding.Services
{
    public class onboardstatusService
    {

        private ApplicationDbContext _context;
        public onboardstatusService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void ChangeApprovalStatus(int lid,int Empid,onboardstatusVM onboardstatus)
        {
            var _onboard = new ApprovalStatus()
            {
                Login_Id = lid,
                EmpGen_Id = Empid,
                Current_Status = (int)Status.Approved,
                Comments="",
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = "Admin",
                Modified_by = "Admin",
                Status = "A",
            };
            _context.ApprovalStatus.Add(_onboard);
            _context.SaveChanges();

            var official = _context.EmployeeGeneralDetails.FirstOrDefault(e => e.Login_ID == lid);

            official.Empid = onboardstatus.Emp_id;
            official.Official_EmailId = onboardstatus.Official_EmailId;

            _context.EmployeeGeneralDetails.Update(official);
            _context.SaveChanges();
        }

        public void ChangeCancelStatus(int lid, int Empid,commentVM onboardstatus)
        {
            var _onboard = new ApprovalStatus()
            {
                Login_Id = lid,
                EmpGen_Id = Empid,
                Current_Status = (int)Status.Rejected,
                Comments = onboardstatus.Comments,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = "Admin",
                Modified_by = "Admin",
                Status = "A",
            };
            _context.ApprovalStatus.Add(_onboard);
            _context.SaveChanges();
        }

        public void ChangePendingStatus(int lid, int Empid)
        {
            var _onboard = new ApprovalStatus()
            {
                Login_Id = lid,
                EmpGen_Id = Empid,
                Current_Status = (int)Status.Pending,
                Comments = "",
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = Empid.ToString(),
                Modified_by = "Admin",
                Status = Status.Pending.ToString(),
            };
            _context.ApprovalStatus.Add(_onboard);
            _context.SaveChanges();
        }

    }
    
}
