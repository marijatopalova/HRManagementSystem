﻿using HRManagementSystem.Domain.Entities;

namespace HRManagementSystem.Infrastructure.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<Employee> GetByIdAsync(int id);
        Task<IEnumerable<Employee>> GetAllAsync();
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);
    }
}