using HRManagementSystem.Domain.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Infrastructure.LeaveManagement.Interfaces
{
    public interface ILeaveRequestRepository
    {
        Task<LeaveRequest> GetByIdAsync(int id);
        Task<IEnumerable<LeaveRequest>> GetAllAsync();
        Task AddAsync(LeaveRequest leaveRequest);
        Task UpdateAsync(LeaveRequest leaveRequest);
        Task DeleteAsync(int id);
    }
}
