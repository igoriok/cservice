using System;
using System.Collections.Generic;

namespace Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);
        void Remove(TEntity item);
        void Register(TEntity item);
        void Modify(TEntity item);

        IEnumerable<TEntity> GetAll();
    }
}
