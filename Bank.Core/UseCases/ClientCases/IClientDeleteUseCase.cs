using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.UseCases.ClientCases
{
    public interface IClientDeleteUseCase
    {
        Task<Guid> Execute(Guid id);
    }
}
