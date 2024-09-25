using HRManagementSystem.Application.Commands;
using HRManagementSystem.Application.DTOs;
using HRManagementSystem.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IMediator mediator) : ControllerBase
    {
        [HttpGet("id")]
        public async Task<ActionResult<EmployeeDto>> GetEmployeeByIdAsync(int id)
        {
            var query = new GetEmployeeByIdQuery { Id = id };
            var result = await mediator.Send(query);

            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> GetAllEmployeesAsync()
        {
            var query = new GetAllEmployeesQuery();
            var result = await mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateEmployee([FromBody] CreateEmployeeCommand command)
        {
            var employeeId = await mediator.Send(command);
            return Ok(employeeId);
        }
    }
}
