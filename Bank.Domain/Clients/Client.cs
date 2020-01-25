using System;
using Bank.Domain;


namespace Bank.Domain.Clients
{
    public sealed class Client : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Company Company { get; set; }


        public Client( string firstName, string lastName, Company company)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Company = company;
        }

        public Client(Guid id, string firstName, string lastName, Company company)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Company = company;
        }

        private Client() { }

        public static Client LoadFromDetails(Guid id, string firstname, string lastName, Guid companyId, string companyName)
        {
            Client client = new Client();
            client.Id = id;
            client.FirstName = firstname;
            client.LastName = lastName;
            client.Company = new Company(companyId, companyName);
            return client;
        }
    }
}
