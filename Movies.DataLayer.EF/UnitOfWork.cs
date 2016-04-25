using Movies.DataLayer.Contracts;
using Movies.DataLayer.Contracts.Entities;
using Movies.DataLayer.EF.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataLayer.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext context;

        private IRepository<Movie> moviesRepository;

        public IRepository<Movie> MoviesRepository
        {
            get
            {
                if (moviesRepository == null)
                {
                    moviesRepository = new GenericRepository<Movie>(context);
                }

                return moviesRepository;
            }
        }

        private IRepository<Actor> actorsRepository;

        public IRepository<Actor> ActorsRepository
        {
            get
            {
                if (actorsRepository == null)
                {
                    actorsRepository = new GenericRepository<Actor>(context);
                }

                return actorsRepository;
            }
        }

        public UnitOfWork()
        {
            this.context = new MoviesContext();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
