using Movies.DataLayer.Contracts;
using Movies.DataLayer.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataLayer.EF
{
    public class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private DbSet<TEntity> dbSet;

        private DbContext context;

        public GenericRepository(DbContext context)
        {
            dbSet = context.Set<TEntity>();
            this.context = context;
        }

        public IQueryable<TEntity> Read()
        {
            return dbSet;
        }

        public TEntity Create(TEntity entity)
        {
            return dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);

            var entityData = context.Entry(entity);
            entityData.State = EntityState.Modified;
        }

        public bool Delete(int id)
        {
            var instance = dbSet.FirstOrDefault(x => x.Id == id);

            if (instance != null)
            {
                dbSet.Remove(instance);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
