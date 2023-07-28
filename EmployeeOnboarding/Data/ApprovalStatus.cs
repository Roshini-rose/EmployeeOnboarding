using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class ApprovalStatus:BaseEntity
    {
        [ForeignKey("Empid")]
        public string Empid { get; set; }
        public string Empname { get; set; }
        public bool? Approved { get; set; }
        public bool? Cancelled { get; set; }

    }
}
