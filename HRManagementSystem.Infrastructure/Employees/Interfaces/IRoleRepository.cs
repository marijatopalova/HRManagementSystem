using HRManagementSystem.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Infrastructure.Employees.Interfaces
{
    public interface IRoleRepository
    {
        Task<Role> GetByIdAsync(int id);
        Task<IEnumerable<Role>> GetAllAsync();
        Task AddAsync(Role role);
        Task DeleteAsync(int id);
    }
}
