using Movies.BusinessLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.DataLayer.Contracts.Entities;
using Movies.DataLayer.Contracts;

namespace Movies.BusinessLayer.BL2016
{
    public class Movies : BusinessObjectBase, IMovies
    {
        public Movies(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public Movie Create(Movie movie)
        {
            return unitOfWork.MoviesRepository.Create(movie);
        }
    }
}
