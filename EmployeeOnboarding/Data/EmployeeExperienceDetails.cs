using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeExperienceDetails:BaseEntity
    {
        [ForeignKey("EmpGen_Id")]
        public int? EmpGen_Id { get; set; }
        public string? Company_name { get; set; }
        public string? Designation { get; set; }
        public string? Reason { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public string? Exp_Certificate { get; set; } 
    }
}
