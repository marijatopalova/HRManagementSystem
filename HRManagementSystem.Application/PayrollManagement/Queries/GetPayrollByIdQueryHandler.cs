using HRManagementSystem.Application.PayrollManagement.DTOs;
using HRManagementSystem.Infrastructure.PayrollManagement.Interfaces;
using MediatR;

namespace HRManagementSystem.Application.PayrollManagement.Queries
{
    public class GetPayrollByIdQueryHandler(IPayrollRepository payrollRepository) : IRequestHandler<GetPayrollByIdQuery, PayrollDto>
    {
        public async Task<PayrollDto> Handle(GetPayrollByIdQuery request, CancellationToken cancellationToken)
        {
            var payroll = await payrollRepository.GetByIdAsync(request.Id);

            return new PayrollDto
            {
                Id = request.Id,
                Amount = payroll.Amount,
                EmployeeId = payroll.EmployeeId,
                PaymentDate = payroll.PaymentDate,
            };
        }
    }
}
