namespace EmployeeOnboarding.ViewModels
{
    public class WorkExperienceVM
    {
        public string? Company_name { get; set; }
        public string? Designation { get; set; }
        public string? Reason { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public IFormFile? Exp_Certificate { get; set; }
    }
}
