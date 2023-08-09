using System.ComponentModel.DataAnnotations;

namespace EmployeeOnboarding.Data.Enum
{
    public enum DisabilityType
    {
        [Display(Name ="Blindness")]
        Blindness=1,
        [Display(Name = "Hearing Impairment")]
        Hearing_Impairment=2,
        [Display(Name ="Handicap")]
        Handicap=3,
        [Display(Name ="Mental Illness")]
        Mental_Illness=4,
        [Display(Name = "Intellectual Disability")]
        Intellectual_Disability =5,
        [Display(Name = "Leprosy Cured Person")]
        Leprosy_cured_person = 6,
        [Display(Name ="Others")]
        others=7
    }
}
