using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.UserCommand
{
    public record UpdateUserCommand(Guid id, User user) : IRequest<User>;

    public class UpdateUserCommandHandler(IUserRepository _userRepository) : IRequestHandler<UpdateUserCommand, User>
    {
        public async Task<User> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            return await _userRepository.UpdateUserAsync(request.id, request.user);
        }
    }
}
