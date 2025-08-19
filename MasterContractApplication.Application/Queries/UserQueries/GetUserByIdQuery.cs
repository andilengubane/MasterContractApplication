using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.UserQueries
{
    public record GetUserByIdQuery(Guid Id) : IRequest<User>;

    public class GetUserByIdQueryHandler(IUserRepository _userRepository) : IRequestHandler<GetUserByIdQuery, User>
    {
        public async Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            return await _userRepository.GetUserByIdAsync(request.Id);
        }
    }
}
