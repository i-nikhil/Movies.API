using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Movies.Domain.Entities.Configurations
{
    public class MovieGenreConfig : IEntityTypeConfiguration<MovieGenreMappings>
    {
        public void Configure(EntityTypeBuilder<MovieGenreMappings> builder)
        {
            builder.HasKey(p => new { p.MovieId, p.GenreId });
        }
    }
}
