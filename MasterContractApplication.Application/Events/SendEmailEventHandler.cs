using MediatR;
using Microsoft.Extensions.Logging;

namespace MasterContractApplication.Application.Events;

public class SendEmailEventHandler(ILogger<SendEmailEventHandler> logger) : INotificationHandler<UserCreatedEvent>
{
    public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
    {
        logger.LogInformation($"User create: send email start {notification.userId}");
        await Task.Delay(2000, cancellationToken);
        logger.LogInformation($"User create: send email done {notification.userId}");
    }
}

