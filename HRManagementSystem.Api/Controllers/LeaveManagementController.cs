using HRManagementSystem.Application.LeaveManagement.Commands;
using HRManagementSystem.Application.LeaveManagement.DTOs;
using HRManagementSystem.Application.LeaveManagement.Queries;
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

        [HttpGet("id")]
        public async Task<ActionResult<LeaveRequestDto>> GetLeaveRequestByIdAsync(int id)
        {
            var query = new GetLeaveRequestByIdQuery { Id = id };

            var result = await mediator.Send(query);
            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
