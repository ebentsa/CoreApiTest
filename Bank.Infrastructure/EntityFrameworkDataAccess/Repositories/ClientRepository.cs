using Bank.Core.Interfaces;
using Bank.Domain;
using Bank.Domain.Clients;
using System;
using System.Threading.Tasks;

namespace Bank.Infrastructure.EntityFrameworkDataAccess.Repositories
{
    class ClientRepository : IClientRepository
    {
        private readonly BankContext _context;

        public ClientRepository(BankContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(Client client)
        {
            Entities.Client clientEntity = new Entities.Client()
            {
                ClientId = client.Id,
                FirstName = client.FirstName,
                LastName = client.FirstName,
                Company = new Entities.Company(client.Company.Id, client.Company.Name)
            };

            await _context.Clients.AddAsync(clientEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<Client> GetById(Guid id)
        {
            Entities.Client client = await _context.Clients
                .FindAsync(id);

            return Client.LoadFromDetails(client.ClientId, client.FirstName, client.LastName,  client.Company.Id, client.Company.Name);
        }

        public async Task Delete(Guid id)
        {
            Entities.Client clientEntity = await _context.Clients
                .FindAsync(id);

            _context.Clients.Remove(clientEntity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Client client)
        {
            Entities.Client clientEntity = new Entities.Client()
            {
                ClientId = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Company = new Entities.Company(client.Company.Id, client.Company.Name),
            };

            _context.Clients.Update(clientEntity);
            await _context.SaveChangesAsync();
        }
    }
}
