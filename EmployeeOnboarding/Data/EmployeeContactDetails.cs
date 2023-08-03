using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeContactDetails
    {
        public int Id { get; set; }
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; }  
        public string Personal_Emailid { get; set; }
        public double Contact_no { get; set; }
        public string? Emgy_Contactperson { get; set; }
        public int? Emgy_Contactrelation { get; set; }
        public double? Emgy_Contactno { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string Created_by { get; set; }
        public string? Modified_by { get; set; }
        public string Status { get; set; }
    }
}
