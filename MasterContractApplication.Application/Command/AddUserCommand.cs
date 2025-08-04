using MasterContractApplication.Application.Events;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Application.Command
{
    public record class AddUserCommand(User user): IRequest<User>;

    public class AddUserCommandHandler(IUserRepository userRepository, IMediator mediator)
        : IRequestHandler<AddUserCommand, User>
    {
        public async Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = await userRepository.AddUserAsync(request.user);
            await mediator.Publish(new UserCreatedEvent(user.Id));
            return user;
        }
    }
}
