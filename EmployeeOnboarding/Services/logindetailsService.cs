using EmployeeOnboarding.Data;
using EmployeeOnboarding.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using OnboardingWebsite.Models;
using System.Data;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc.Routing;
using EmployeeOnboarding.Data.Enum;

namespace EmployeeOnboarding.Services
{
    public class logindetailsService
    {
        
        private ApplicationDbContext _context;
        private IEmailSender emailSender;

        public logindetailsService(ApplicationDbContext context, IEmailSender emailSender)
        {
            _context = context;
            this.emailSender = emailSender;
        }

        public async void LoginInvite(logininviteVM logindet)
        {
            var _logindet = new Login()
            {
                Name = logindet.Name,
                EmailId = logindet.Emailid,
                Date_Created = DateTime.UtcNow,
                Date_Modified = DateTime.UtcNow,
                Created_By = "Admin",
                Modified_By = "Admin",
                Status = "A",
                //Status = "Invited",
            };

            _context.Login.Add(_logindet);
            _context.SaveChanges();
        
            //var callbackUrl = "http://localhost:7136/swagger/index.html";
            ////var callbackUrl = "http://localhost:7136/api/logindetails/confirm-login";

            //await emailSender.SendEmailAsync(logindet.Emailid, "Confirm your email",
            //           $"Please confirm your account by  <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'> clicking here.");
        }

        public void LoginConfirm(string Emailid,loginconfirmVM logindet)
        {
            var confirm = _context.Login.FirstOrDefault(e => e.EmailId == Emailid);
            if (logindet.Password == logindet.Conf_Password)
            {
                confirm.Password = logindet.Password;
                confirm.Date_Modified = DateTime.UtcNow;
                confirm.Modified_By = "User";
                confirm.Status = "A";
                //confirm.Status = "Confirmed";

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
                confirm.Status = "A";
               // confirm.Status = "Confirmed";

                _context.Login.Update(confirm);
                _context.SaveChanges();
                return confirm;
            }
            else
                return (null);
        }
    }
}
