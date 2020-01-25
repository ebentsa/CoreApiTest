using Bank.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Interfaces
{
    public interface ICompanyRepository
    {
        Task Add(Company company);
        Task<Company> GetById(Guid id);
        Task Update(Company company);
        Task Delete(Company company);
    }
}
