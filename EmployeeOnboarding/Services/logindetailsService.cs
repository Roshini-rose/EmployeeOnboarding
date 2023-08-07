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
        public void LoginInvite(logininviteVM logindet)
        {
            var _logindet = new Login()
            {
                Name = logindet.Name,
                EmailId = logindet.Emailid,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_By = "Admin",
                Modified_By = "Admin",
                Status = "Invited",
            };
            _context.Login.Add(_logindet);
            _context.SaveChanges();
        }

        public void LoginConfirm(string Emailid,loginconfirmVM logindet)
        {
            var confirm = _context.Login.FirstOrDefault(e => e.EmailId == Emailid);
            if (logindet.Password == logindet.Conf_Password)
            {
                confirm.Password = logindet.Password;
                confirm.Date_Modified = DateTime.UtcNow;
                confirm.Modified_By = "User";
                confirm.Status = "Confirmed";

                _context.Login.Update(confirm);
                _context.SaveChanges();
            }
            else
                confirm.Password = null;

        }

        public async Task<Login> LoginCmp(string Emailid,loginconfirmVM logindet)
        {
            var confirm = _context.Login.FirstOrDefault(e => e.EmailId == Emailid);
            if (logindet.Password == logindet.Conf_Password)
            {
                confirm.Password = logindet.Password;
                confirm.Date_Modified = DateTime.UtcNow;
                confirm.Modified_By = "User";
                confirm.Status = "Confirmed";

                _context.Login.Update(confirm);
                _context.SaveChanges();
                return confirm;
            }
            else
                return (null);
        }

        public async Task<Login> LoginEmp(string Emailid, string Password)
        {
            var _succeeded = _context.Login.FirstOrDefault(n => n.EmailId == Emailid && n.Password == Password);
            if (_succeeded == null)
                return null;
            else
                return (_succeeded);
        }
    }
    
}
