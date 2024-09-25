using MediatR;

namespace HRManagementSystem.Application.Commands
{
    public class CreateDepartmentCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
