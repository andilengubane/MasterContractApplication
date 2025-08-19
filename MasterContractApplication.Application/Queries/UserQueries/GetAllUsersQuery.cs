using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.UserQueries
{
    public record GetAllUsersQuery() : IRequest<IEnumerable<User>>;

    public class GetAllUsersQueryHandler(IUserRepository _userRepository): IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
    {
        public async Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetAllAsync();
        }
    }
}
