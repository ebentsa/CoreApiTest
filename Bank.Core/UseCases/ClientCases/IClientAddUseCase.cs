using Bank.Domain.Clients;
using System;
using System.Threading.Tasks;

namespace Bank.Core.UseCases.ClientCases
{
    public interface IClientAddUseCase
    {
        Task<Guid> Execute(ClientOutput client);
    }
}
