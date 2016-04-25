using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movies.BusinessLayer.Contracts;
using Movies.Common.IoCContainer;
using Movies.DataLayer.Contracts.Entities;

namespace Movies.BusinessLayer.BL2016.Tests
{
    [TestClass]
    public class MoviesTests
    {
        [TestMethod]
        public void Create_NewMovie_SaveChangesInDb()
        {
            var uow = Resolver.Get<IBusinessObjectFactory>();
            var movie = new Movie()
            {
                Director = "Laci",
                PremierDate = DateTime.Now.Date,
                Title = "Mariska"
            };

            uow.Movies.Create(movie);
            uow.SaveChanges();
        }
    }
}
