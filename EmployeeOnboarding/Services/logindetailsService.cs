using EmployeeOnboarding.Data;
using EmployeeOnboarding.ViewModels;
using System.Data;
using System.Xml.Linq;

namespace EmployeeOnboarding.Services
{
    public class logindetailsService
    {
        private ApplicationDbContext _context;
        public logindetailsService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void LoginDetails(logindetailsVM logindet)
        {
            var _logindet = new Login()
            {
                Empid=logindet.empId,
                Name=logindet.Name,
                Emailid=logindet.Emailid,
                Password=logindet.Password, 
                Designation=logindet.Designation,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_by = "Admin",
                Modified_by = "Admin",
                Status = "Created",
            };
            _context.Logins.Add(_logindet);
            _context.SaveChanges();
        }

        public async Task<Login> LoginEmp(string Emailid,string Password)
        {
            var _succeeded =_context.Logins.FirstOrDefault(n => n.Emailid == Emailid && n.Password == Password);
            if( _succeeded == null )
                return null;
            else
                return (_succeeded); 
        }
    }
}
