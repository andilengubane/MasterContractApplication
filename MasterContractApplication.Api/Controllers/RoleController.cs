using MasterContractApplication.Application.Command;
using MasterContractApplication.Application.Command.Roles;
using MasterContractApplication.Application.Queries;
using MasterContractApplication.Application.Queries.Roles;
using MasterContractApplication.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace MasterContractApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController(ISender sender) : ControllerBase
    {

        [HttpPost("")]
        public async Task<IActionResult> AddUserAsync([FromBody] Role role)
        {
            var result = await sender.Send(new AddRoleCommand(role));
            return Ok(result);
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllRoleAsync()
        {
            var result = await sender.Send(new GetAllRoleQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleByIdAsync([FromRoute] Guid id)
        {
            var result = await sender.Send(new GetRoleByIdQuery(id));
            return Ok(result);
        }
    }
}
