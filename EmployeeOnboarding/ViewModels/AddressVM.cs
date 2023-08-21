using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.ViewModels
{
    public class AddressVM
    {
        public string Address_Type { get; set; }
        public string Address { get; set; }
        public int Country_Id { get; set; }
        public int State_Id { get; set; }
        public int City_Id { get; set; }
        public string Pincode { get; set; }

    }
}
