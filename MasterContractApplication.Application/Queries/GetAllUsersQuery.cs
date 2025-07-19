using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MediatR;

namespace MasterContractApplication.Application.Queries
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
