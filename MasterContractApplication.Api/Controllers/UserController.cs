using MasterContractApplication.Application.Command;
using MasterContractApplication.Application.Queries;
using MasterContractApplication.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MasterContractApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(ISender sender) : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> AddUserAsync([FromBody] User user) 
        {
            var result = await sender.Send(new AddUserCommand(user));
            return Ok(result);
        }

        [HttpGet()]
        public async Task<IActionResult> GetAllUserAsync()
        {
            var result = await sender.Send(new GetAllUsersQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserByIdAsync([FromRoute]Guid Id)
        {
            var result = await sender.Send(new GetUserByIdQuery(Id));
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserByAsync([FromRoute] Guid Id , [FromBody] User user)
        {
            var result = await sender.Send(new UpdateUserCommand(Id, user));
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserAsync([FromRoute] Guid Id)
        {
            var result = await sender.Send(new RemoveUserCommand(Id));
            return Ok(result);
        }
    }
}
