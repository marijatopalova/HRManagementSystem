using HRManagementSystem.Application.LeaveManagement.DTOs;
using HRManagementSystem.Application.PayrollManagement.Commands;
using HRManagementSystem.Application.PayrollManagement.DTOs;
using HRManagementSystem.Application.PayrollManagement.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.Api.Controllers
{
    [Route("api/payroll")]
    [ApiController]
    public class PayrollController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<int>> CreatePayrollAsync([FromBody] CreatePayrollCommand command)
        {
            await mediator.Send(command);
            return Ok();
        }

        [HttpGet("id")]
        public async Task<ActionResult<PayrollDto>> GetPayrollByIdAsync(int id)
        {
            var query = new GetPayrollByIdQuery { Id = id };

            var result = await mediator.Send(query);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
