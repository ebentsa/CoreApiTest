using Bank.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.UseCases.ClientCases
{
    public interface IClientGetByIdUseCase
    {
        Task<ClientOutput> Execute(Guid id);
    }
}
