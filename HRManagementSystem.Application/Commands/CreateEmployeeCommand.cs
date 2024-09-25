using MediatR;

namespace HRManagementSystem.Application.Commands
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int DepartmentId { get; set; }
    }
}
