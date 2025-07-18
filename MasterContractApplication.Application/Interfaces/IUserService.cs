using MasterContractApplication.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Application.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetByIdAsync(int Id);
        Task<IEnumerable<UserDto>> GetUserAsync();
        Task<UserDto> CreateUser(CeateUserDto userDto);
        Task UpdateUaserAsyn(int Id, UpdateUserDto userDto) => Task.CompletedTask;
        Task DeleteUserAsync(int Id);
    }
}
