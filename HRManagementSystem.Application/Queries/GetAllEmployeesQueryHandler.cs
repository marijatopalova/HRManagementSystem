﻿using HRManagementSystem.Application.DTOs;
using HRManagementSystem.Infrastructure.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Queries
{
    public class GetAllEmployeesQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetAllEmployeesQuery, IEnumerable<EmployeeDto>>
    {
        public async Task<IEnumerable<EmployeeDto>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            var employees = await employeeRepository.GetAllAsync();

            return employees.Select(x => new EmployeeDto
            {
                Id = x.Id,
                Name = x.Name,
                DepartmentId = x.DepartmentId,
                Position = x.Position
            });
        }
    }
}