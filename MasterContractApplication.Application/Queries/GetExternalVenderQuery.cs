using MasterContractApplication.Domain.DTO;
using MasterContractApplication.Domain.Interfaces;
using MediatR;

namespace MasterContractApplication.Application.Queries
{
    public record GetExternalVenderQuery(): IRequest<ExternalVenderDto>;

    internal class GetExternalVenderQueryHanlder(IExternalVenderRepository externalVenderRepository) : IRequestHandler<GetExternalVenderQuery, ExternalVenderDto>
    {
        public async Task<ExternalVenderDto> Handle(GetExternalVenderQuery request, CancellationToken cancellationToken)
        {
            return await externalVenderRepository.GetData();
        }
    }
}
