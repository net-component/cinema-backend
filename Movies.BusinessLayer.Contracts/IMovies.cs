using Movies.DataLayer.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.Contracts
{
    public interface IMovies
    {
        Movie Create(Movie movie);
    }
}
