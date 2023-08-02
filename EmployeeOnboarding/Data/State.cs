using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeOnboarding.Data
{
    public class State
    {
        public int Id { get; set; }
        [ForeignKey("State_Id")]
        public int State_Id { get; set; }
        public string State_Name { get; set; }
    }
}
