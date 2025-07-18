using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Infrastructure.Repositories
{
    public class UserRepository
    {
        private readonly MasterContractApplicationContext _masterContractApplicationContext;
        public UserRepository(MasterContractApplicationContext contractApplicationContext)
        {
           _masterContractApplicationContext = contractApplicationContext;  
        }

        public async Task<User> GetByIdAsync(int userId)
        {
            return await _masterContractApplicationContext.Users.FindAsync(userId);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _masterContractApplicationContext.Users.ToListAsync();
        }

        public async Task<User> AddUserAsync(User user)
        {
            await _masterContractApplicationContext.AddAsync(user);
            await _masterContractApplicationContext.SaveChangesAsync();
            return user;
        }

        public async Task UpdateUserAsync(User user)
        { 
          _masterContractApplicationContext.Users.Update(user);
          await _masterContractApplicationContext.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int userId)
        {
            var deleteUser = await GetByIdAsync(userId);
            _masterContractApplicationContext.Users.Remove(deleteUser);
            await _masterContractApplicationContext.SaveChangesAsync();
        }
    }
}
