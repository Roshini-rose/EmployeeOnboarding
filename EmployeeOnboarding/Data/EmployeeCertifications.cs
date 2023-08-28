using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeCertifications
    {
        public int Id { get; set; }
        [ForeignKey("EmpGen_Id")]
        public int? EmpGen_Id { get; set; }
        public string? Certificate_name { get; set; }
        public string? Issued_by { get; set; }
        public string? Valid_till { get; set; }
        public string? Duration { get; set; }
        public string? proof { get; set; }
        public DateTime? Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string? Created_by { get; set; }
        public string? Modified_by { get; set; }
        public string? Status { get; set; }

    }
}
