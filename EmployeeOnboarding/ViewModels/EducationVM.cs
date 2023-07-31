using Microsoft.AspNetCore.Http;
namespace EmployeeOnboarding.Models
{
    public class EducationVM
    {
        public string programme { get; set; }
        public string CollegeName { get; set; }
        public string Degree { get; set; }
        public string specialization { get; set; }
        public int Passoutyear { get; set; }
        public string Certificate { get; set; }
    }
}
