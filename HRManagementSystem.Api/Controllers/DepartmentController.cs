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
    public class DepartmentController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<int>> CreateDepartmentAsync([FromBody] CreateDepartmentCommand command)
        {
            var departmentId = await mediator.Send(command);
            return Ok(departmentId);
        }

        [HttpGet("id")]
        public async Task<ActionResult<DepartmentDto>> GetDepartmentByIdAsync(int id)
        {
            var query = new GetDepartmentByIdQuery { Id = id };
            var result = await mediator.Send(query);

            if(result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartmentDto>>> GetAllDepartmentsAsync()
        {
            var departments = await mediator.Send(new GetAllDepartmentsQuery());
            return Ok(departments);
        }
    }
}
