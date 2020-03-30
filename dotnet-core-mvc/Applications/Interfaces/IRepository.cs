using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_core_mvc.Applications.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(Guid id);

        IQueryable<TEntity> GetAll();

        void Add(TEntity Entity);

        void Update(TEntity Entity);

        void Delete(TEntity Entity);
    }
}
