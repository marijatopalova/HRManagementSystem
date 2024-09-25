using HRManagementSystem.Domain.Entities;
using HRManagementSystem.Infrastructure.Interfaces;
using MediatR;

namespace HRManagementSystem.Application.Employees.Commands
{
    public class CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository) : IRequestHandler<CreateEmployeeCommand, int>
    {
        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                Name = request.Name,
                Email = request.Email,
                RoleId = request.RoleId,
                DepartmentId = request.DepartmentId
            };

            await employeeRepository.AddAsync(employee);
            return employee.Id;
        }
    }
}
