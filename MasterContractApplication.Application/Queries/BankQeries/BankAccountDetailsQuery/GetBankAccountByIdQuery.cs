using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.BankQeries.BankAccountDetailsQuery
{
    public record GetBankAccountByIdQuery(Guid Id): IRequest<BankAccount>;
    public class GetBankAccountByIdQueryHandler(IBankAccountRepository _bankAccountRepository) : IRequestHandler<GetBankAccountByIdQuery, BankAccount>
    {
        public async Task<BankAccount> Handle(GetBankAccountByIdQuery request, CancellationToken cancellationToken)
        {
            return await _bankAccountRepository.GetBankAccountByIdAsync(request.Id);
        }
    }
}
