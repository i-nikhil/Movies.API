using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Movies.Domain.Entities.Configurations
{
    public class MovieGenreConfig : IEntityTypeConfiguration<MovieGenreMapping>
    {
        public void Configure(EntityTypeBuilder<MovieGenreMapping> builder)
        {
            builder.HasKey(p => new { p.MovieId, p.GenreId });
        }
    }
}
