using MediatR;

namespace HRManagementSystem.Application.Commands
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }
    }
}
