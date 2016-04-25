using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.Contracts
{
    public interface IBusinessObjectFactory
    {
        IMovies Movies { get; }

        void SaveChanges();
    }
}
