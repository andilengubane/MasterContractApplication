using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.InventoryQueries.AssignInventoryQueries
{
    public record GetAssignInventoryByIdQuery(Guid Id): IRequest<AssignInventory>;

    public class GetAssignInventoryByIdQueryHandler(IAssignInventoryRepository _assignInventoryRepository) : IRequestHandler<GetAssignInventoryByIdQuery, AssignInventory>
    {
        public async Task<AssignInventory> Handle(GetAssignInventoryByIdQuery request, CancellationToken cancellationToken)
        {
            return await _assignInventoryRepository.GetAssignInventoryByIdAsync(request.Id);
        }
    }
}
