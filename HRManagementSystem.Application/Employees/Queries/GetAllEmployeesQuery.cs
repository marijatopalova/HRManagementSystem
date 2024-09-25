using HRManagementSystem.Application.Employees.DTOs;
using MediatR;

namespace HRManagementSystem.Application.Employees.Queries
{
    public class GetAllEmployeesQuery : IRequest<IEnumerable<EmployeeDto>>
    {
    }
}
