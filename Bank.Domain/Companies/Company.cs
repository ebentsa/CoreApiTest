using System;

namespace Bank.Domain
{
    public sealed class Company : IEntity, IAggregateRoot
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }


        public Company( string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Company(Guid id, string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        private Company() { }

        public static Company LoadFromDetails(Guid id, string name)
        {
            Company company = new Company();
            company.Id = id;
            company.Name = name;
            return company;
        }
    }
}
