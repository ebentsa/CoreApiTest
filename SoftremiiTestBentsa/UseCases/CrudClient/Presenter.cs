using Bank.Core;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApi.Bank.UseCases.CrudClient;

namespace WebApi.Bank.UseCases.AddClient
{
    public sealed class Presenter
    {
        public IActionResult ViewModel { get; private set; }

        public void Populate(Guid output)
        {
            if (output == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new OkResult();
        }

        public void Populate(ClientOutput client)
        {
            if (client == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ClientModel model = new ClientModel(
                client.ClientId,
                client.FirstName,
                client.LastName,
                new CompanyModel(client.Company.Id, client.Company.Name)
            );

            ViewModel = new CreatedAtRouteResult("GetCustomer", new { clientId = model.ClientId }, model);
        }
    }
}
