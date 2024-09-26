using HRManagementSystem.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Infrastructure.Employees.Interfaces
{
    public interface IPerformanceReviewRepository
    {
        Task<PerformanceReview> GetByIdAsync(int id);
        Task<IEnumerable<PerformanceReview>> GetAllAsync();
        Task AddAsync(PerformanceReview review);
        Task UpdateAsync(PerformanceReview review);
        Task DeleteAsync(int id);
    }
}
