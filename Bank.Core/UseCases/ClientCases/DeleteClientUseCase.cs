using Bank.Core.Interfaces;
using Bank.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.UseCases.ClientCases
{
    public sealed class DeleteClientUseCase : IClientDeleteUseCase
    {
        private readonly IClientRepository _clientRepository;

        public DeleteClientUseCase(
            IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task Execute(Guid clientId)
        {
            Client account = await _clientRepository.GetById(clientId);
            if (account == null)
                throw new ClientNotFoundException($"The client {clientId} does not exists or is already deleted.");

            await _clientRepository.Delete(clientId);

        }

    }
}
