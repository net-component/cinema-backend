using Movies.DataLayer.Contracts.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Movies.DataLayer.EF.EntityConfigurations
{
    class ProgramConfiguration : EntityTypeConfiguration<Program>
    {
        public ProgramConfiguration()
        {
            Property(p => p.MovieId)
                .IsRequired()
                .HasUniqueIndexAnnotation("Program_UQ", 0);
            Property(p => p.RoomId)
                .IsRequired()
                .HasUniqueIndexAnnotation("Program_UQ", 1);
            Property(p => p.When)
                .IsRequired()
                .HasUniqueIndexAnnotation("Program_UQ", 2);
        }
    }
}
