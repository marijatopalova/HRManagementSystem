using HRManagementSystem.Application.Employees.Commands;
using HRManagementSystem.Application.Employees.DTOs;
using HRManagementSystem.Application.Employees.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.Api.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        [HttpGet("id")]
        public async Task<ActionResult<EmployeeDto>> GetEmployeeByIdAsync(int id)
        {
            var query = new GetEmployeeByIdQuery { Id = id };
            var result = await mediator.Send(query);

            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet("employees")]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetAllEmployeesAsync()
        {
            var query = new GetAllEmployeesQuery();
            var result = await mediator.Send(query);

            return Ok(result);
        }

        [HttpPost("new-employee")]
        public async Task<ActionResult<int>> CreateEmployeeAsync([FromBody] CreateEmployeeCommand command)
        {
            var employeeId = await mediator.Send(command);
            return Ok(employeeId);
        }

        [HttpPost("performance-review")]
        public async Task<ActionResult<int>> AddPerformanceReviewAsync([FromBody] CreatePerformanceReviewCommand command)
        {
            var performanceReviewId = await mediator.Send(command);
            return Ok(performanceReviewId);
        }

        [HttpPost("role")]
        public async Task<ActionResult<int>> CreateRoleAsync([FromBody] CreateRoleCommand command)
        {
            var roleId = await mediator.Send(command);
            return Ok(roleId);
        }
    }
}
