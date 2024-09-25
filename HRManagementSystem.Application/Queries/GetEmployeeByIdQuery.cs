using HRManagementSystem.Application.DTOs;
using MediatR;

namespace HRManagementSystem.Application.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeDto>
    {
        public int Id { get; set; }
    }
}
