using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.UserQueries
{
    public record GetAllUsersQuery() : IRequest<IEnumerable<User>>;

    internal class GetAllUsersQueryHandler(IUserRepository userRepository)
         : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
    {
        public async Task<IEnumerable<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            return await userRepository.GetAllAsync();
        }
    }
}
