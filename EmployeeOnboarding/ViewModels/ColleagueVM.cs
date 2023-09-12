using Microsoft.AspNetCore.Http;
namespace OnboardingWebsite.Models
{
    public class ColleagueVM
    {
        public string Relationship { get; set; }
        public int child_no { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Occupation { get; set; }
        public long Contact_no { get; set; }
    }
}
