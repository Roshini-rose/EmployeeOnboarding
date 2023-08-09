

using System.ComponentModel.DataAnnotations;

namespace EmployeeOnboarding.Data.Enum
{
    public enum BloodGroup
    {
        [Display(Name = "O+")]
        OPositive=1,
        [Display(Name = "A+")]
        APositive=2,
        [Display(Name = "B+")]
        BPositive=3,
        [Display(Name = "AB+")]
        ABPositive=4,
        [Display(Name = "AB-")]
        ABNegative=5,
        [Display(Name = "A-")]
        ANegative=6,
        [Display(Name = "B-")]
        BNegative=7,
        [Display(Name = "O-")]
        ONegative=8
    }
}
