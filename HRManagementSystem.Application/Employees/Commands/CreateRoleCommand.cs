using MediatR;

namespace HRManagementSystem.Application.Employees.Commands
{
    public class CreateRoleCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
