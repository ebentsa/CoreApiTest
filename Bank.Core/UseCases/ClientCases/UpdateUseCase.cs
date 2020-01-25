using Bank.Core.Interfaces;
using Bank.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.UseCases.ClientCases
{
    class UpdateUseCase : IClientUpdateUseCase
    {
        private readonly IClientRepository _clientRepository;

        public UpdateUseCase(
            IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Guid> Execute(ClientOutput clientoutput)
        {
            Client client = new Client(clientoutput.ClientId, clientoutput.FirstName, clientoutput.LastName, clientoutput.Company);
            await _clientRepository.Update(client);
            return client.Id;

        }
    }
}
