using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Domain.Employees
{
    public class PerformanceReview
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public string Feedback { get; set; }
        public int Rating { get; set; } // Rating scale (1-5)
        public Employee Employee { get; set; }
    }
}
