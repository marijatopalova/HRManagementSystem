using HRManagementSystem.Application.PayrollManagement.DTOs;
using MediatR;

namespace HRManagementSystem.Application.PayrollManagement.Queries
{
    public class GetPayrollByIdQuery : IRequest<PayrollDto>
    {
        public int Id { get; set; }
    }
}
