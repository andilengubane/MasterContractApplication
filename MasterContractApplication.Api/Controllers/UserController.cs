using MasterContractApplication.Application.DTOs;
using MasterContractApplication.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MasterContractApplication.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDto>>> GetAllUser()
        {
            var allUser = await _userService.GetUserAsync();
            return Ok(allUser);
        }

        [HttpGet("Id")]
        public async Task<ActionResult<UserDto>> GetUserById(int Id)
        {
            var user = await _userService.GetByIdAsync(Id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<UserDto>> CreateUser(CeateUserDto user)
        { 
            var create = await _userService.CreateUser(user);
            return CreatedAtAction(nameof(GetAllUser), new { create.Id }, create);
        }

        [HttpPut("Id")]
        public async Task<ActionResult<UserDto>> UpdateUser(int Id, UpdateUserDto updateUserDto)
        {
            await _userService.UpdateUaserAsyn(Id, updateUserDto);
            return NoContent();
        }

        [HttpDelete("Id")]
        public async Task<ActionResult> DeleteUser(int Id)
        { 
          await _userService.DeleteUserAsync(Id);
          return NoContent();
        }
    }
}
