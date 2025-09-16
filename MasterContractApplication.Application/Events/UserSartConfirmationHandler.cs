using MediatR;
using Microsoft.Extensions.Logging;

namespace MasterContractApplication.Application.Events
{
    public class UserSartConfirmationHandler(ILogger<UserSartConfirmationHandler> logger) : INotificationHandler<UserCreatedEvent>
    {
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation($"User create: User {notification.userId} initail date {DateTime.Today}");
            await Task.Delay(2000, cancellationToken);
            logger.LogInformation($"User create: User {notification.userId}");
        }
    }
}
