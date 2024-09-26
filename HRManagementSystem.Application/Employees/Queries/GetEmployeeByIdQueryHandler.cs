using HRManagementSystem.Application.Employees.DTOs;
using HRManagementSystem.Infrastructure.Employees.Interfaces;
using MediatR;

namespace HRManagementSystem.Application.Employees.Queries
{
    public class GetEmployeeByIdQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetEmployeeByIdQuery, EmployeeDto>
    {
        public async Task<EmployeeDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var employee = await employeeRepository.GetByIdAsync(request.Id);
            return new EmployeeDto()
            {
                Id = employee.Id,
                Name = employee.Name,
                DepartmentId = employee.DepartmentId,
                RoleId = employee.RoleId,
                Email = employee.Email,
            };
        }
    }
}
