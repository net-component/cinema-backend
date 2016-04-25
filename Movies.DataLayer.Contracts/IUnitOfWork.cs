using Movies.DataLayer.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataLayer.Contracts
{
    public interface IUnitOfWork
    {
        IRepository<Movie> MoviesRepository { get; }

        IRepository<Actor> ActorsRepository { get; }

        void SaveChanges();
    }
}
