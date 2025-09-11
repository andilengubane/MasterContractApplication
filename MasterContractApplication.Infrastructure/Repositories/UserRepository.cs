using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class UserRepositor (MasterContractApplicationContext _masterContractApplicationContext) : IUserRepository
    {

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _masterContractApplicationContext.Users.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid Id)
        {
            var user = await _masterContractApplicationContext.Users.FirstOrDefaultAsync(u => u.Id == Id);

            if (user == null)
                throw new KeyNotFoundException($"No user found with Id: {Id}");

            return user;
        }

        public async Task<User> AddUserAsync(User user)
        {
            user.Id = Guid.NewGuid();
            _masterContractApplicationContext.Add(user);
            await _masterContractApplicationContext.SaveChangesAsync();
            return user;
        }

        public async Task<User> UpdateUserAsync(Guid Id,User user)
        { 
           var userUpdate = await _masterContractApplicationContext.Users.SingleOrDefaultAsync(u => u.Id == Id);
            if (userUpdate is not null)
            {
                userUpdate.FisrtName = user.FisrtName;
                userUpdate.LastName = user.FisrtName;
                userUpdate.EmailAddress = user.Password;
                userUpdate.Password = user.Password;
                userUpdate.RegNumber = user.RegNumber;
                userUpdate.IsActived = user.IsActived;
                userUpdate.RoleId = user.RoleId;
                userUpdate.PermissionId = user.PermissionId;

                await _masterContractApplicationContext.SaveChangesAsync();

                return userUpdate;
            }
            return user;
        }

        public async Task<bool> RemoveUserAsync(Guid Id)
        {
            var deleteUser = await _masterContractApplicationContext.Users.SingleOrDefaultAsync(u => u.Id == Id);
            if (deleteUser is not null) {
                _masterContractApplicationContext.Users.Remove(deleteUser);
                return await _masterContractApplicationContext.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
