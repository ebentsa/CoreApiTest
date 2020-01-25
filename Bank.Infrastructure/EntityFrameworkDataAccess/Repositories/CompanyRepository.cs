using Bank.Core.Interfaces;
using Bank.Domain;
using System;

using System.Threading.Tasks;

namespace Bank.Infrastructure.EntityFrameworkDataAccess.Repositories
{
    class CompanyRepository : ICompanyRepository
    {
        private readonly BankContext _context;

        public CompanyRepository(BankContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public async Task Add(Company company)
        {
            Entities.Company companyEntity = new Entities.Company()
            {
                Id = company.Id,
                Name = company.Name
            };

            await _context.Companies.AddAsync(companyEntity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Company company)
        {
            Entities.Company companyEntity = await _context.Companies
                .FindAsync(company.Id);

            _context.Companies.Remove(companyEntity);
            await _context.SaveChangesAsync();
        }

        public async Task<Company> GetById(Guid id)
        {
            Entities.Company companyEntity = await _context.Companies
                .FindAsync(id);

            return Company.LoadFromDetails(companyEntity.Id, companyEntity.Name);
        }



        public async Task Update(Company company)
        {
            Entities.Company companyEntity = new Entities.Company()
            {
                Id = company.Id,
                Name = company.Name,
            };

            _context.Companies.Update(companyEntity);
            await _context.SaveChangesAsync();
        }

    }
}
