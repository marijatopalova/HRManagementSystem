using HRManagementSystem.Domain.Departments;

namespace HRManagementSystem.Infrastructure.Departments.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<Department> GetByIdAsync(int id);
        Task<IEnumerable<Department>> GetAllAsync();
        Task AddAsync(Department department);
        Task UpdateAsync(Department department);
        Task DeleteAsync(int id);
    }
}
