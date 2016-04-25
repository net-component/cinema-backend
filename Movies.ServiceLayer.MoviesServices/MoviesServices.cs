using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.DataLayer.Contracts.Entities;
using Movies.BusinessLayer.Contracts;
using Movies.Common.IoCContainer;

namespace Movies.ServiceLayer.MoviesServices
{
    class MoviesServices : IMoviesServices
    {
        public Movie Create(Movie movie)
        {
            var uow = Resolver.Get<IBusinessObjectFactory>();

            uow.Movies.Create(movie);

            uow.SaveChanges();

            return movie;
        }
    }
}
