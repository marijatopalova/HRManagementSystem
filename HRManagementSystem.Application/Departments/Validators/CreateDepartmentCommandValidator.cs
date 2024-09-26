using FluentValidation;
using HRManagementSystem.Application.Departments.Commands;

namespace HRManagementSystem.Application.Departments.Validators
{
    public class CreateDepartmentCommandValidator : AbstractValidator<CreateDepartmentCommand>
    {
        public CreateDepartmentCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Department name is required.")
                .MaximumLength(200).WithMessage("Department name must not exceed 200 characters.");
        }
    }
}
