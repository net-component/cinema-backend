using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Movies.DataLayer.EF.Context;
using Movies.DataLayer.Contracts.Entities;

namespace Movies.DataLayer.EF.Tests
{
    [TestClass]
    public class GenericRepositoryTests
    {
        [TestMethod]
        public void Create_Movie_MovieGetsSaveInDb()
        {
            // Arrange
            var unitOfWork = new UnitOfWork();

            var repository = unitOfWork.MoviesRepository;

            var movie = new Movie()
            {
                Director = "Nemes Jeles Laszlo",
                PremierDate = new DateTime(2015, 6, 11),
                Title = "Saul fia II."
            };

            repository.Create(movie);
            unitOfWork.SaveChanges();

            // Act

            // Assert
        }
    }
}
