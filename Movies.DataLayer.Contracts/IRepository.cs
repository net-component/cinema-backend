using Movies.DataLayer.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataLayer.Contracts
{
    public interface IRepository<TEntity>
        where TEntity : IEntity
    {
        IQueryable<TEntity> Read();

        TEntity Create(TEntity entity);

        void Update(TEntity entity);

        bool Delete(int id);
    }
}
