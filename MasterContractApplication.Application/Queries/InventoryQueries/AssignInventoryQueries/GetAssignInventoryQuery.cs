using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.InventoryQueries.AssignInventoryQueries
{
    public record GetAssignInventoryQuery() : IRequest<IEnumerable<AssignInventory>>;

    public class GetAssignInventoryQueryHandler(IAssignInventoryRepository _assignInventoryRepository): IRequestHandler<GetAssignInventoryQuery, IEnumerable<AssignInventory>>
    {
        public async Task<IEnumerable<AssignInventory>> Handle(GetAssignInventoryQuery request, CancellationToken cancellationToken)
        {
            return await _assignInventoryRepository.GetAllAssignInventoryAsync();
        }
    }
}