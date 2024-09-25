using HRManagementSystem.Domain.Entities;
using HRManagementSystem.Infrastructure.Interfaces;
using MediatR;

namespace HRManagementSystem.Application.Commands
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
