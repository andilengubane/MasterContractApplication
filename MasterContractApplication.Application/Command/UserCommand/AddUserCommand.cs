using MediatR;
using MasterContractApplication.Application.Events;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Command.UserCommand
{
    public record AddUserCommand(User user) : IRequest<User>;

    public class AddUserCommandHandler(IUserRepository _userRepository, IMediator mediator): IRequestHandler<AddUserCommand, User>
    {
        public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.AddUserAsync(request.user);
            await mediator.Publish(new UserCreatedEvent(user.Id));
            return user;
        }
    }
}
