﻿using HRManagementSystem.Domain.PayrollManagement;
using HRManagementSystem.Infrastructure.PayrollManagement.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.PayrollManagement.Commands
{
    public class CreatePayrollCommandHandler(IPayrollRepository payrollRepository) : IRequestHandler<CreatePayrollCommand>
    {
        public async Task Handle(CreatePayrollCommand request, CancellationToken cancellationToken)
        {
            var payroll = new Payroll
            {
                EmployeeId = request.EmployeeId,
                Amount = request.Amount,
                PaymentDate = request.PaymentDate
            };

            await payrollRepository.AddAsync(payroll);
        }
    }
}
