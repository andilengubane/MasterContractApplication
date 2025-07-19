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

        [HttpGet("user")]
        public async Task<IActionResult> GetAllUserAsync()
        {
            var result = await sender.Send(new GetAllUsersQuery());
            return Ok(result);
        }
    }
}
