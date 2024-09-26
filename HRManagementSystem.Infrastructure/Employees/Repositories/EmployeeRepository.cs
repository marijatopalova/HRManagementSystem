using HRManagementSystem.Domain.Employees;
using HRManagementSystem.Infrastructure.Data;
using HRManagementSystem.Infrastructure.Employees.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Infrastructure.Employees.Repositories
{
    public class EmployeeRepository(ApplicationDbContext dbContext) : IEmployeeRepository
    {
        public async Task<Employee> GetByIdAsync(int id)
        {
            return await dbContext.Employees
                .Include(e => e.Department)
                .Include(e => e.Role)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await dbContext.Employees
                .Include(e => e.Department)
                .Include(e => e.Role)
                .ToListAsync();
        }

        public async Task AddAsync(Employee employee)
        {
            await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Employee employee)
        {
            dbContext.Employees.Update(employee);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await GetByIdAsync(id);
            if (employee != null)
            {
                dbContext.Employees.Remove(employee);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
