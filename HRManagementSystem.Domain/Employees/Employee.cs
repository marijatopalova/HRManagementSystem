using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRManagementSystem.Domain.Departments;
using HRManagementSystem.Domain.LeaveManagement;

namespace HRManagementSystem.Domain.Employees
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }
        public Role Role { get; set; }
        public Department Department { get; set; }
        public ICollection<PerformanceReview> PerformanceReviews { get; set; }
        public ICollection<LeaveRequest> LeaveRequests { get; set; }
    }
}
