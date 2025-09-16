using MediatR;

namespace MasterContractApplication.Application.Events
{
    public record UserCreatedEvent(Guid userId) : INotification;
    
}
