using HRManagementSystem.Application.LeaveManagement.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.Api.Controllers
{
    [Route("api/leave-management")]
    [ApiController]
    public class LeaveManagementController(IMediator mediator) : ControllerBase
    {
        [HttpPost("leave-request")]
        public async Task<ActionResult<int>> CreateLeaveRequestAsync([FromBody] CreateLeaveRequestCommand command)
        {
            var leaveRequestId = await mediator.Send(command);
            return Ok(leaveRequestId);
        }
    }
}
