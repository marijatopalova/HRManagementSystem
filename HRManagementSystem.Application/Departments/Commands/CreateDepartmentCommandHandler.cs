using HRManagementSystem.Domain.Departments;
using HRManagementSystem.Infrastructure.Departments.Interfaces;
using MediatR;

namespace HRManagementSystem.Application.Departments.Commands
{
    public class CreateDepartmentCommandHandler(IDepartmentRepository departmentRepository) : IRequestHandler<CreateDepartmentCommand, int>
    {
        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new Department
            {
                Name = request.Name,
            };

            await departmentRepository.AddAsync(department);
            return department.Id;
        }
    }
}
