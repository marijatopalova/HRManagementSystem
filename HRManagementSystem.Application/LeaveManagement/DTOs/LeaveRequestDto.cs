using HRManagementSystem.Domain.LeaveManagement;

namespace HRManagementSystem.Application.LeaveManagement.DTOs
{
    public class LeaveRequestDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public LeaveStatus Status { get; set; } 
    }
}
