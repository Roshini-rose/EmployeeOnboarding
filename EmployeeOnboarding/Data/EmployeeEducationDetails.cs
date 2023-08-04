using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeEducationDetails
    {
        public int Id { get; set; }
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; }
        public string programme { get; set; }  
        public string CollegeName { get; set; }
        public string Degree { get; set; } 
        public string specialization { get; set; }
        public int Passoutyear { get; set; }
        public string Certificate { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string Created_By { get; set; }
        public string? Modified_By { get; set; }
        public string Status { get; set; }
    }
}
