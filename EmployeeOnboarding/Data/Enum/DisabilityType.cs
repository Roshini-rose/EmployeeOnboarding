using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeOnboarding.Data.Enum
{
    public enum DisabilityType
    {
        [Description("Blindness")]
        Blindness =1,
        [Description("Hearing Impairment")]
        Hearing_Impairment=2,
        [Description("Handicap")]
        Handicap=3,
        [Description("Mental Illness")]
        Mental_Illness=4,
        [Description("Intellectual Disability")]
        Intellectual_Disability =5,
        [Description("Leprosy Cured Person")]
        Leprosy_cured_person = 6,
        [Description("Others")]
        others=7
    }
}
