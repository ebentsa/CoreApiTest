using Microsoft.AspNetCore.Mvc;
using System;
using Bank.Core.UseCases.ClientCases;
using System.Threading.Tasks;
using Bank.Domain.Clients;
using Bank.Core;

namespace WebApi.Bank.UseCases.AddClient
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private readonly IClientAddUseCase _clientAddUseCase;
        private readonly IClientUpdateUseCase _clientUpdateUseCase;
        private readonly IClientGetByIdUseCase _clientGetByIdUseCase;
        private readonly IClientDeleteUseCase _clientDeleteUseCase;
        private readonly Presenter _presenter;

        public ClientController(
            IClientAddUseCase clientAddUseCase, IClientUpdateUseCase clientUpdateUseCase, 
            IClientGetByIdUseCase clientGetByIdUseCase, IClientDeleteUseCase clientDeleteUseCase,
            Presenter presenter)
        {
            _clientAddUseCase = clientAddUseCase;
            _clientUpdateUseCase = clientUpdateUseCase;
            _clientGetByIdUseCase = clientGetByIdUseCase;
            _clientDeleteUseCase = clientDeleteUseCase;
            _presenter = presenter;
        }

        [HttpGet("{clientId}", Name = "GetClient")]
        public async Task<IActionResult> Get(Guid clientId)
        {
            ClientOutput output = await _clientGetByIdUseCase.Execute(clientId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }

        [HttpPost("{clientId}", Name = "AddClient")]
        public async Task<IActionResult> Post([FromBody] ClientOutput client)
        {
            Guid output = await _clientAddUseCase.Execute(client);

            _presenter.Populate(output);
            return _presenter.ViewModel;
        }


        [HttpPut("{clientId}", Name = "UpdateClient")]
        public async Task<IActionResult> Put([FromBody] ClientOutput client)
        {
            Guid output =  await _clientUpdateUseCase.Execute(client);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }

        [HttpDelete("{clientId}")]
        public async Task<IActionResult> Delete(Guid clientId)
        {
            Guid output = await _clientDeleteUseCase.Execute(clientId);
            _presenter.Populate(output);
            return _presenter.ViewModel;
        }
    }
}
