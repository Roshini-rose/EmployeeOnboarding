using System.ComponentModel.DataAnnotations;

namespace EmployeeOnboarding.Data
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public string Created_by { get; set; }
        public string? Modified_by { get; set; }
        public string Status { get; set; }
    }
}
