using Bank.Core.Interfaces;
using Bank.Domain;
using Bank.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.UseCases.ClientCases
{
    class AddClientUseCase : IClientAddUseCase
    {
        private readonly IClientRepository _clientRepository;

        public AddClientUseCase(
            IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Guid> Execute(ClientOutput clientNew)
        {
            Client client = new Client(clientNew.FirstName, clientNew.LastName, new Company(clientNew.Company.Id, clientNew.Company.Name));
            await _clientRepository.Add(client);
            return client.Id;
        }

    }
}
