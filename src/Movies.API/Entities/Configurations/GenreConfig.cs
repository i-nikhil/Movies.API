using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Movies.API.Entities.Configurations;

public class GenreConfig : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.Property(p => p.Name).IsRequired().HasConversion<string>();
        builder.HasIndex(p => p.Name).IsUnique().HasFilter("DeletedAt Is NULL");
        builder.Property(p => p.CreatedAt).HasColumnType("datetime");
        builder.Property(p => p.UpdatedAt).HasColumnType("datetime");
        builder.Property(p => p.DeletedAt).HasColumnType("datetime");
    }
}
