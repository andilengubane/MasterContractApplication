using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Application.DTOs;
using MasterContractApplication.Application.Interfaces;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userService;  
        
        public UserService(IUserRepository userRepository)
        {
           _userService = userRepository;
        }

        public async Task<UserDto> GetByIdAsync(int Id)
        {
            var user = await _userService.GetByIdAsync(Id);
            return new UserDto(user.Id, user.FisrtName, user.LastName, user.EmailAddress, user.Password, user.RegNumber, user.IsActived, user.UserRole);
        }

        public async Task<IEnumerable<UserDto>> GetUserAsync()
        { 
           var allUsers = await _userService.GetAllAsync();
           return allUsers.Select(u => new UserDto(u.Id, u.FisrtName, u.LastName, u.EmailAddress, u.Password, u.RegNumber, u.IsActived, u.UserRole));
        }

        public async Task<UserDto> CreateUser(CeateUserDto userDto)
        {
            var user = new User(userDto.FisrtName, userDto.LastName, userDto.EmailAddress, userDto.Password, userDto.RegNumber, userDto.IsActived, userDto.UserRole);
            var createuser = await _userService.AddUserAsync(user);
            return new UserDto(createuser.Id,createuser.FisrtName, createuser.LastName, createuser.EmailAddress, createuser.Password, createuser.RegNumber, createuser.IsActived, createuser.UserRole);
        }

        public async Task UpdateUaserAsyn(int Id, UpdateUserDto userDto)
        {
            var user = await _userService.GetByIdAsync(Id);
            user.UpdateUser(userDto.FisrtName, userDto.LastName, userDto.EmailAddress, userDto.Password, userDto.RegNumber, userDto.IsActived, userDto.UserRole);
            await _userService.UpdateUserAsync(user);
        }

        public async Task DeleteUserAsync(int Id)
        { 
           await _userService.DeleteUserAsync(Id);
        }
    }
}
