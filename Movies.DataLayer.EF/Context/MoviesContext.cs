using Movies.DataLayer.Contracts.Entities;
using Movies.DataLayer.EF.EntityConfigurations;
using System.Data.Entity;

namespace Movies.DataLayer.EF.Context
{
    class MoviesContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Program> Programs { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public MoviesContext() : base("name=Movies")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ProgramConfiguration());
        }
    }
}
