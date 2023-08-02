using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeAdditionalInfo:BaseEntity
    {
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; } 
        public bool? Disability { get; set; }
        public string? Disablility_type { get; set; }
        public string Covid_VaccSts { get; set; }
        public string? Vacc_Certificate { get; set; }
    }
}
