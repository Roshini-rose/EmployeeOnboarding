using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class ApporvalStatus:BaseEntity
    {
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; }
        public string Current_Status { get; set; }
        public string Comments { get; set; }

    }
}
