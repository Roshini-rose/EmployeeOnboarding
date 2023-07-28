using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class EmployeeGeneralDetails:BaseEntity
    {
        [ForeignKey("Empid")]
        public string Empid { get; set; }
        public string EmployeeName { get; set; }
        public DateTime DOB {  get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string MaritalName { get; set; }
        public DateTime? DateOfMarriage { get; set; }
        public string BloodGrp { get; set; }   

    }
}
