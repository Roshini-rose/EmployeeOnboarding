using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeEducationDetails:BaseEntity
    {
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; }
        public string programme { get; set; }  
        public string CollegeName { get; set; }
        public string Degree { get; set; } 
        public string specialization { get; set; }
        public int Passoutyear { get; set; }
        public string Certificate { get; set; }
    }
}
