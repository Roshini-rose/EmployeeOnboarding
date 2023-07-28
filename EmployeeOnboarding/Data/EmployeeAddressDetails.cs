using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace EmployeeOnboarding.Data
{
    public class EmployeeAddressDetails:BaseEntity
    {
        [ForeignKey("Empid")]
        public string Empid { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }
}
