using MediatR;
using MasterContractApplication.Domain.DTO;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.ExtensionQueries
{
    public record GetExternalVenderQuery() : IRequest<ExternalVenderDto>;

    public class GetExternalVenderQueryHanlder(IExternalVenderRepository _externalVenderRepository) : IRequestHandler<GetExternalVenderQuery, ExternalVenderDto>
    {
        public async Task<ExternalVenderDto> Handle(GetExternalVenderQuery request, CancellationToken cancellationToken)
        {
            return await _externalVenderRepository.GetData();
        }
    }
}