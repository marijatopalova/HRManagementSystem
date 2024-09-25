using HRManagementSystem.Application.PayrollManagement.Commands;
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
    }
}
