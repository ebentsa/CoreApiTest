using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Core.Interfaces
{
    public interface IReadOnlyRepository
    {
        T GetById<T>(int id);
    }
}
