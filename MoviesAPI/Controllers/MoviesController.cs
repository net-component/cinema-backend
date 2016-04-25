using Movies.BusinessLayer.Contracts;
using Movies.Common.IoCContainer;
using Movies.DataLayer.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace MoviesAPI.Controllers
{
    public class MoviesController : ApiController
    {
        public Movie Post([FromBody] Movie movie)
        {
            var uow = Resolver.Get<IBusinessObjectFactory>();

            var newMovie = uow.Movies.Create(movie);

            return newMovie;
        }
    }
}