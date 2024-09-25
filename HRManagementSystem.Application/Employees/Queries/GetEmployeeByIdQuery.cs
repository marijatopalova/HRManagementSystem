using HRManagementSystem.Application.Employees.DTOs;
using MediatR;

namespace HRManagementSystem.Application.Employees.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeDto>
    {
        public int Id { get; set; }
    }
}
