using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeGeneralDetails:BaseEntity
    {
        [ForeignKey("Login_Id")]
        public int Login_ID { get; set; }    
        public string Empid { get; set; }
        public string EmployeeName { get; set; }
        public string Official_EmailId { get; set; }
        public DateOnly DOB {  get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string MaritalName { get; set; }
        public DateOnly DateOfMarriage { get; set; }
        public string BloodGrp { get; set; }   

    }
}
