using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContractApplication.Application.Events
{
    public record UserCreatedEvent(Guid userId) : INotification;
    
}
