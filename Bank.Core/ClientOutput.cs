using Bank.Domain;
using Bank.Domain.Clients;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Core
{
    public sealed class ClientOutput
    {
        public Guid ClientId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public Company Company { get; }

        public ClientOutput(
            Client client)
        {
            ClientId = client.Id;
            FirstName = client.FirstName;
            LastName = client.LastName;
            Company = client.Company;
        }
    }
}
