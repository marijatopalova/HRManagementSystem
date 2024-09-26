using FluentValidation;
using HRManagementSystem.Application.LeaveManagement.Commands;

namespace HRManagementSystem.Application.LeaveManagement.Validators
{
    public class CreateLeaveRequestCommandValidator : AbstractValidator<CreateLeaveRequestCommand>
    {
        public CreateLeaveRequestCommandValidator()
        {
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Start date is required");

            RuleFor(x => x.EndDate).NotEmpty().WithMessage("End date is required");
        }
    }
}
