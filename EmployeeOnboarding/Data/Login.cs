using System.ComponentModel.DataAnnotations;

namespace EmployeeOnboarding.Data
{
    public class Login : BaseEntity
    {
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        
    }
}
