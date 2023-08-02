using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace EmployeeOnboarding.ViewModels
{
    public class statusdashVM
    {
        public int TotalRequests { get; set; }

        public int ApprovedRequests { get; set; }

        //public int PendingRequests { get; set; }

        public int RejectedRequests { get; set; }
    }
}
