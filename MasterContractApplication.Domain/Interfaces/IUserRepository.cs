using MasterContractApplication.Domain.Entities;

namespace MasterContractApplication.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int userId);

        Task<IEnumerable<User>> GetAllAsync();

        Task<User> AddUserAsync(User user);

        Task UpdateUserAsync(User user);

        Task DeleteUserAsync(int userId);
    }
}
