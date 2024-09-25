using HRManagementSystem.Application.DTOs;
using MediatR;

namespace HRManagementSystem.Application.Queries
{
    public class GetAllEmployeesQuery : IRequest<IEnumerable<EmployeeDto>>
    {
    }
}
