using HRManagementSystem.Application.Departments.Commands;
using HRManagementSystem.Application.Departments.DTOs;
using HRManagementSystem.Application.Departments.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HRManagementSystem.Api.Controllers
{
    [Route("api/department")]
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

        [HttpPost("settings")]
        public async Task<ActionResult<int>> CreateDepartmentSettingsAsync([FromBody] CreateDepartmentSettingsCommand command)
        {
            var settingsId = await mediator.Send(command);
            return Ok(settingsId);
        }
    }
}
