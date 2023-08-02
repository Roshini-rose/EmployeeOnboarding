using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class ApprovalStatus:BaseEntity
    {
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; }
        public int Current_Status { get; set; }
        public string? Comments { get; set; }

    }
}
