using HRManagementSystem.Application.DTOs;
using HRManagementSystem.Infrastructure.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Queries
{
    public class GetDepartmentByIdQueryHandler(IDepartmentRepository departmentRepository) : IRequestHandler<GetDepartmentByIdQuery, DepartmentDto>
    {
        public async Task<DepartmentDto> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var department = await departmentRepository.GetByIdAsync(request.Id);

            return new DepartmentDto
            {
                Id = department.Id,
                Name = department.Name
            };
        }
    }
}
