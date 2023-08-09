using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;

namespace EmployeeOnboarding.Data.Enum
{
    public enum VaccinationStatus
    {
        [Display(Name ="None")]
        None=1,
        [Display(Name ="Partially Vaccinated")]
        Partially_Vaccinated=2,
        [Display(Name ="Fully Vaccinated")]
        Fully_Vaccinated=3
    }
}
