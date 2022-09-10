using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movies.Domain.Entities;

namespace Movies.Infrastructure.Configurations;

public class MovieConfig : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(p => p.Title).IsRequired();
        builder.Property(p => p.ReleaseYear).IsRequired();
        builder.Property(p => p.RuntimeMinutes).IsRequired();
    }
}
