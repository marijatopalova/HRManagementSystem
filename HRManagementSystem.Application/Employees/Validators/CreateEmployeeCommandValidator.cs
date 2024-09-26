using FluentValidation;
using HRManagementSystem.Application.Employees.Commands;

namespace HRManagementSystem.Application.Employees.Validators
{
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters.");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Name is required.")
                .EmailAddress().WithMessage("Email must be valid.");
        }
    }
}
