using MasterContractApplication.Domain.Interfaces;
using MediatR;

namespace MasterContractApplication.Application.Command.UserCommand
{
    public record RemoveUserCommand(Guid id) : IRequest<bool>;

    public class RemoveUserCommandHandler(IUserRepository userRepository) : IRequestHandler<RemoveUserCommand, bool>
    {
        public Task<bool> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            return userRepository.DeleteUserAsync(request.id);
        }
    }
}
