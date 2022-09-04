using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;

namespace Movies.Infrastructure.Configurations
{
    public class MovieGenreConfig : IEntityTypeConfiguration<MovieGenreMapping>
    {
        public void Configure(EntityTypeBuilder<MovieGenreMapping> builder)
        {
            builder.HasKey(p => new { p.MovieId, p.GenreId });
        }
    }
}
