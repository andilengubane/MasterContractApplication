using MediatR;
using MasterContractApplication.Domain.Entities;
using MasterContractApplication.Domain.Interfaces;

namespace MasterContractApplication.Application.Queries.BankQeries.BankAccountDetailsQuery
{
    public  record GetAllBankAccountQuery() : IRequest<IEnumerable<BankAccount>>;

    public class GetAllBankAccountQueryHandle(IBankAccountRepository _bankAccountRepository) : IRequestHandler<GetAllBankAccountQuery, IEnumerable<BankAccount>>
    {
        public async Task<IEnumerable<BankAccount>> Handle(GetAllBankAccountQuery request, CancellationToken cancellationToken)
        {
            return await _bankAccountRepository.GetAllBankAccountAsync();
        }
    }
}
