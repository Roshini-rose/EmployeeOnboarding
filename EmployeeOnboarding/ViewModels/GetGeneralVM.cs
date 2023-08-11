namespace EmployeeOnboarding.ViewModels
{
    public class GetGeneralVM
    {

       
        public string EmployeeName { get; set; }
        public  DateOnly DOB { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }
        public string? MaritalStatus { get; set; }
        public DateOnly? DateOfMarriage { get; set; }
        public string BloodGrp { get; set; }
    }
}
