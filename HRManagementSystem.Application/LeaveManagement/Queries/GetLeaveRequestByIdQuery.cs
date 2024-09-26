using HRManagementSystem.Application.LeaveManagement.DTOs;
using MediatR;

namespace HRManagementSystem.Application.LeaveManagement.Queries
{
    public class GetLeaveRequestByIdQuery : IRequest<LeaveRequestDto>
    {
        public int Id { get; set; }
    }
}
