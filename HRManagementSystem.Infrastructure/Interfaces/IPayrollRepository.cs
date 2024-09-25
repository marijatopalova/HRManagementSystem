﻿using HRManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Infrastructure.Interfaces
{
    public interface IPayrollRepository
    {
        Task<Payroll> GetByIdAsync(int id);
        Task<IEnumerable<Payroll>> GetAllAsync();
        Task AddAsync(Payroll payroll);
        Task UpdateAsync(Payroll payroll);
        Task DeleteAsync(int id);
    }
}