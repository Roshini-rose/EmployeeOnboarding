using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace EmployeeOnboarding.Data
{
    public class EmployeeAddressDetails
    {
        public int Id { get; set; }
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; }
        public string Per_Address { get; set; }
        [ForeignKey("Per_Country_Id")]
        public int Per_Country_Id { get; set; }
        [ForeignKey("Per_State_Id")]
        public int Per_State_Id { get; set; }
        [ForeignKey("Per_City_Id")]
        public int Per_City_Id { get; set; }
        public string Per_Pincode { get; set; }
        public string Temp_Address { get; set; }
        [ForeignKey("Temp_Country_Id")]
        public int Temp_Country_Id { get; set; }
        [ForeignKey("Temp_State_Id")]
        public int Temp_State_Id { get; set; }
        [ForeignKey("Temp_City_Id")]
        public int Temp_City_Id { get; set; }
        public string Temp_Pincode { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string Created_by { get; set; }
        public string? Modified_by { get; set; }
        public string Status { get; set; }

    }
}
//