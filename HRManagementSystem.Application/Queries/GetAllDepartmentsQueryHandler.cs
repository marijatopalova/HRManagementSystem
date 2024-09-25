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
    public class GetAllDepartmentsQueryHandler(IDepartmentRepository departmentRepository) : IRequestHandler<GetAllDepartmentsQuery, IEnumerable<DepartmentDto>>
    {
        public async Task<IEnumerable<DepartmentDto>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var departments = await departmentRepository.GetAllAsync();

            return departments.Select(x => new DepartmentDto
            {
                Id = x.Id,
                Name = x.Name,
            });
        }
    }
}
