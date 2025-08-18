using MasterContractApplication.Application.Queries.InventoryQueries.InventoryDetailsQueries;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;
using MediatR;

namespace MasterContractApplication.Application.Queries.InventoryQueries.AssignInventoryQueries
{
    public record GetAssignInventoryQuery() : IRequest<IEnumerable<AssignInventory>>;

    internal class GetAssignInventoryQueryHandler(IAssignInventoryRepository assignInventoryRepository)
       : IRequestHandler<GetAssignInventoryQuery, IEnumerable<AssignInventory>>
    {
        public async Task<IEnumerable<AssignInventory>> Handle(GetAssignInventoryQuery request, CancellationToken cancellationToken)
        {
            return await assignInventoryRepository.GetAllAssignInventoryAsync();
        }
    }
}
