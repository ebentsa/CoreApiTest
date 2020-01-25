using Bank.Core.Interfaces;
using Bank.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.UseCases.ClientCases
{
    class GetClientUseCase : IClientGetByIdUseCase
    {
        private readonly IClientRepository _clientRepository;

        public GetClientUseCase(
            IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<ClientOutput> Execute(Guid id)
        {
            var client = await _clientRepository.GetById(id);
            return new ClientOutput(client); ;
        }
    }
}
