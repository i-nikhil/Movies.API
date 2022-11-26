using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Movies.API.Entities.Configurations;

public class MovieGenreConfig : IEntityTypeConfiguration<MovieGenreMapping>
{
    public void Configure(EntityTypeBuilder<MovieGenreMapping> builder)
    {
        builder
        .HasOne(mg => mg.Movie)
        .WithMany(m => m.Genres);

        builder
        .HasOne(mg => mg.Genre)
        .WithMany(m => m.Movies);
    }
}
