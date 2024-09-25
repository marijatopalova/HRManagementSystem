using MediatR;

namespace HRManagementSystem.Application.Commands
{
    public class CreateRoleCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
