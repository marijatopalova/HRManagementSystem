using HRManagementSystem.Application.LeaveManagement.DTOs;
using HRManagementSystem.Infrastructure.LeaveManagement.Interfaces;
using MediatR;

namespace HRManagementSystem.Application.LeaveManagement.Queries
{
    public class GetLeaveRequestByIdQueryHandler(ILeaveRequestRepository leaveRequestRepository) : IRequestHandler<GetLeaveRequestByIdQuery, LeaveRequestDto>
    {
        public async Task<LeaveRequestDto> Handle(GetLeaveRequestByIdQuery request, CancellationToken cancellationToken)
        {
            var leaveRequest = await leaveRequestRepository.GetByIdAsync(request.Id);
            var leaveRequestDto = new LeaveRequestDto
            {
                Id = leaveRequest.Id,
                EmployeeId = leaveRequest.EmployeeId,
                StartDate = leaveRequest.StartDate,
                EndDate = leaveRequest.EndDate,
                Status = leaveRequest.Status
            };

            return leaveRequestDto;
        }
    }
}
