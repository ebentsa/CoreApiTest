using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Core.Interfaces
{
    public interface IRepository
    {
        T GetById<T>(int id);
        T Add<T>(T entity);
        void Update<T>(T entity);
        void Delete<T>(T entity);
    }
}
