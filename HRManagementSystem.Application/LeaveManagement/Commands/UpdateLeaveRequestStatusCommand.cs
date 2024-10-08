﻿using HRManagementSystem.Domain.LeaveManagement;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.Application.LeaveManagement.Commands
{
    public class UpdateLeaveRequestStatusCommand : IRequest
    {
        public int LeaveRequestId { get; set; }
        public LeaveStatus Status { get; set; }
    }
}
