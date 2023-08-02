using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace EmployeeOnboarding.Data
{
    public class EmployeeAddressDetails : BaseEntity
    {
        [ForeignKey("EmpGen_Id")]
        public int EmpGen_Id { get; set; }
        public string Address_Type { get; set; }
        public string Address { get; set; }
        [ForeignKey("Country_Id")]
        public int Country_Id { get; set; }
        [ForeignKey("State_Id")]
        public int State_Id { get; set; }
        [ForeignKey("City_Id")]
        public int City_Id { get; set; }
        public string Pincode { get; set; }
 
    }
}
