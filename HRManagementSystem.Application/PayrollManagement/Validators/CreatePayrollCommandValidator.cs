using FluentValidation;
using HRManagementSystem.Application.PayrollManagement.Commands;

namespace HRManagementSystem.Application.PayrollManagement.Validators
{
    public class CreatePayrollCommandValidator : AbstractValidator<CreatePayrollCommand>
    {
        public CreatePayrollCommandValidator()
        {
            RuleFor(x => x.Amount).NotEmpty().WithMessage("Amount must not be empty.");

            RuleFor(x => x.PaymentDate).NotEmpty().WithMessage("Payment date must not be empty.");
        }
    }
}
