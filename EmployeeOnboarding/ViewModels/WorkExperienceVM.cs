namespace EmployeeOnboarding.ViewModels
{
    public class WorkExperienceVM
    {
        public string Company_name { get; set; }
        public string Designation { get; set; }
        public int Totalmonths { get; set; }
        public string Reason { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IFormFile? Exp_Certificate { get; set; }
    }
}
