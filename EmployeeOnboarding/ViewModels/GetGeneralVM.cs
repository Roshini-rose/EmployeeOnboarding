using System.ComponentModel.DataAnnotations;

namespace EmployeeOnboarding.ViewModels
{
    public class GetGeneralVM
    {

        public string Empname { get; set; }
        public DateOnly DOB { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public DateOnly? DateOfMarriage { get; set; }
        public string BloodGrp { get; set; }
    }
}
