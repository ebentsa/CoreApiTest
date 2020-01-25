using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Bank.UseCases.CrudClient
{
    public class CompanyModel
    {
        public Guid Id { get; }
        public string Name { get; }

        public CompanyModel(
           Guid id,
           string name)
        {
            Id = id;
            Name = name;
        }
    }
}
