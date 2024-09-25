using HRManagementSystem.Infrastructure.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.Commands
{
    public class UpdateLeaveRequestStatusCommandHandler(ILeaveRequestRepository leaveRequestRepository) : IRequestHandler<UpdateLeaveRequestStatusCommand>
    {
        public async Task Handle(UpdateLeaveRequestStatusCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await leaveRequestRepository.GetByIdAsync(request.LeaveRequestId);
            if (leaveRequest == null) 
            {
                throw new ArgumentException("Leave request not found.");
            }

            leaveRequest.Status = request.Status;
            await leaveRequestRepository.UpdateAsync(leaveRequest);
        }
    }
}
