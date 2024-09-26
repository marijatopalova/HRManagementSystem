using HRManagementSystem.Domain.LeaveManagement;
using HRManagementSystem.Infrastructure.LeaveManagement.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.LeaveManagement.Commands
{
    public class CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository) : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = new LeaveRequest
            {
                EmployeeId = request.EmployeeId,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                Status = LeaveStatus.Pending,
            };

            await leaveRequestRepository.AddAsync(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
