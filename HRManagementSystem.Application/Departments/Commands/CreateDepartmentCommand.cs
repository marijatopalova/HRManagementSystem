using MediatR;

namespace HRManagementSystem.Application.Departments.Commands
{
    public class CreateDepartmentCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
