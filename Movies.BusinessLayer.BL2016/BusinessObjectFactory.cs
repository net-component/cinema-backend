using Movies.BusinessLayer.Contracts;
using Movies.DataLayer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.BL2016
{
    public class BusinessObjectFactory : IBusinessObjectFactory
    {
        private IUnitOfWork unitOfWork;

        public BusinessObjectFactory(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private IMovies movies;

        public IMovies Movies
        {
            get
            {
                if (movies == null)
                {
                    movies = new Movies(unitOfWork);
                }

                return movies;
            }
        }

        public void SaveChanges()
        {
            unitOfWork.SaveChanges();
        }
    }
}
