using HRManagementSystem.Domain.PayrollManagement;
using HRManagementSystem.Infrastructure.Data;
using HRManagementSystem.Infrastructure.PayrollManagement.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRManagementSystem.Infrastructure.PayrollManagement.Repositories
{
    public class PayrollRepository(ApplicationDbContext dbContext) : IPayrollRepository
    {
        public async Task<Payroll> GetByIdAsync(int id)
        {
            return await dbContext.Payrolls
                .Include(e => e.Employee)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Payroll>> GetAllAsync()
        {
            return await dbContext.Payrolls
                .Include(e => e.Employee)
                .ToListAsync();
        }

        public async Task AddAsync(Payroll payroll)
        {
            await dbContext.Payrolls.AddAsync(payroll);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Payroll payroll)
        {
            dbContext.Payrolls.Update(payroll);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var payroll = await GetByIdAsync(id);
            if (payroll != null)
            {
                dbContext.Payrolls.Remove(payroll);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
