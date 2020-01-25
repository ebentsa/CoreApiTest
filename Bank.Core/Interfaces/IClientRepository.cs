using Bank.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Interfaces
{
    public interface IClientRepository
    {
        Task Add(Client company);
        Task<Client> GetById(Guid id);
        Task Update(Client company);
        Task Delete(Guid id);
    }
}
