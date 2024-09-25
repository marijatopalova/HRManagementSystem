using HRManagementSystem.Domain.Entities;
using HRManagementSystem.Infrastructure.Data;
using HRManagementSystem.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRManagementSystem.Infrastructure.Repositories
{
    public class DepartmentRepository(ApplicationDbContext dbContext) : IDepartmentRepository
    {
        public async Task<Department> GetByIdAsync(int id)
        {
            return await dbContext.Departments
                .Include(d => d.Employees)
                .FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<IEnumerable<Department>> GetAllAsync()
        {
            return await dbContext.Departments
                .Include(d => d.Employees)
                .ToListAsync();
        }

        public async Task AddAsync(Department department)
        {
            await dbContext.Departments.AddAsync(department);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Department department)
        {
            dbContext.Departments.Update(department);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var department = await GetByIdAsync(id);
            if (department != null)
            {
                dbContext.Departments.Remove(department);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
