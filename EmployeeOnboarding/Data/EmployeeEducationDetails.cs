using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeEducationDetails
    {
        public int Id { get; set; }
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; }
        public string Qualification { get; set; }  
        public string University { get; set; }
        public string Institution_name { get; set; }
        public string Degree_achieved { get; set; }
        public string specialization { get; set; }
        public int Passoutyear { get; set; }
        public string Grade { get; set; }
        public string Certificate { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string Created_by { get; set; }
        public string? Modified_by { get; set; }
        public string Status { get; set; }
    }
}
