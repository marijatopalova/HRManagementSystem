using HRManagementSystem.Domain.Departments;
using HRManagementSystem.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Infrastructure.Departments.Interfaces
{
    public interface IDepartmentSettingsRepository
    {
        Task<DepartmentSettings> GetByIdAsync(int id);
        Task<IEnumerable<DepartmentSettings>> GetAllAsync();
        Task AddAsync(DepartmentSettings settings);
        Task UpdateAsync(DepartmentSettings settings);
        Task DeleteAsync(int id);
    }
}
