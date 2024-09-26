using HRManagementSystem.Domain.Departments;
using HRManagementSystem.Infrastructure.Data;
using HRManagementSystem.Infrastructure.Departments.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRManagementSystem.Infrastructure.Departments.Repositories
{
    public class DepartmentSettingsRepository(ApplicationDbContext dbContext) : IDepartmentSettingsRepository
    {
        public async Task<DepartmentSettings> GetByIdAsync(int id)
        {
            return await dbContext.DepartmentSettings
                .Include(e => e.Department)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<DepartmentSettings>> GetAllAsync()
        {
            return await dbContext.DepartmentSettings
                .Include(e => e.Department)
                .ToListAsync();
        }

        public async Task AddAsync(DepartmentSettings settings)
        {
            await dbContext.DepartmentSettings.AddAsync(settings);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(DepartmentSettings settings)
        {
            dbContext.DepartmentSettings.Update(settings);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var settings = await GetByIdAsync(id);
            if (settings != null)
            {
                dbContext.DepartmentSettings.Remove(settings);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
