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
    public class RoleRepository(ApplicationDbContext dbContext) : IRoleRepository
    {
        public async Task AddAsync(Role role)
        {
            await dbContext.AddAsync(role);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var role = await GetByIdAsync(id);
            if (role != null)
            {
                dbContext.Roles.Remove(role);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            return await dbContext.Roles.ToListAsync();
        }

        public async Task<Role> GetByIdAsync(int id)
        {
            return await dbContext.Roles.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
