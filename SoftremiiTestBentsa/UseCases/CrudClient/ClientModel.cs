using System;
using WebApi.Bank.UseCases.CrudClient;

namespace WebApi.Bank.UseCases.CrudClient
{
    public class ClientModel
    {
        public Guid ClientId { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public CompanyModel Company { get; set; }

        public ClientModel( Guid clientId,
            string firstName,
            string lastName,
            CompanyModel company)
        {
            ClientId = clientId;
            FirstName = firstName;
            LastName = lastName;
            Company = company;
        }
    }
}
