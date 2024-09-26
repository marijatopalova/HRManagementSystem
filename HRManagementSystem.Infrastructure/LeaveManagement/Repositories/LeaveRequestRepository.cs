using HRManagementSystem.Domain.LeaveManagement;
using HRManagementSystem.Infrastructure.Data;
using HRManagementSystem.Infrastructure.LeaveManagement.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Infrastructure.LeaveManagement.Repositories
{
    public class LeaveRequestRepository(ApplicationDbContext dbContext) : ILeaveRequestRepository
    {
        public async Task<LeaveRequest> GetByIdAsync(int id)
        {
            return await dbContext.LeaveRequests
                .Include(e => e.Employee)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<LeaveRequest>> GetAllAsync()
        {
            return await dbContext.LeaveRequests
                .Include(e => e.Employee)
                .ToListAsync();
        }

        public async Task AddAsync(LeaveRequest leaveRequest)
        {
            await dbContext.LeaveRequests.AddAsync(leaveRequest);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(LeaveRequest leaveRequest)
        {
            dbContext.LeaveRequests.Update(leaveRequest);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var leaveRequest = await GetByIdAsync(id);
            if (leaveRequest != null)
            {
                dbContext.LeaveRequests.Remove(leaveRequest);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
