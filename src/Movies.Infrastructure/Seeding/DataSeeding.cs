using Microsoft.EntityFrameworkCore;
using Movies.Domain.Entities;

namespace Movies.Infrastructure.Seeding;

public static class DataSeeding
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        Genre comedy = new()
        {
            Id = 1,
            Name = GenreName.Comedy,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Genre drama = new()
        {
            Id = 2,
            Name = GenreName.Drama,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Genre thriller = new()
        {
            Id = 3,
            Name = GenreName.Thriller,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Genre horror = new()
        {
            Id = 4,
            Name = GenreName.Horror,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Genre action = new()
        {
            Id = 5,
            Name = GenreName.Action,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Genre retro = new()
        {
            Id = 6,
            Name = GenreName.Retro,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Genre crime = new()
        {
            Id = 7,
            Name = GenreName.Crime,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Genre biopic = new()
        {
            Id = 8,
            Name = GenreName.Biopic,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Genre fiction = new()
        {
            Id = 9,
            Name = GenreName.Fiction,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Movie avengers = new()
        {
            Id = 1,
            Title = "Avengers",
            ReleaseYear = 2012,
            RuntimeMinutes = 143,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Movie piratesOfTheCaribbean = new()
        {
            Id = 2,
            Title = "Pirates of the Caribbean",
            ReleaseYear = 2003,
            RuntimeMinutes = 143,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Movie noWayHome = new()
        {
            Id = 3,
            Title = "Spider-Man: No way home",
            ReleaseYear = 2022,
            RuntimeMinutes = 148,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Movie theMatrixResurrections = new()
        {
            Id = 4,
            Title = "The Matrix Resurrections",
            ReleaseYear = 2021,
            RuntimeMinutes = 148,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        Movie theConjuring = new()
        {
            Id = 5,
            Title = "The Conjuring",
            ReleaseYear = 2013,
            RuntimeMinutes = 112,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        MovieGenreMapping m1 = new()
        {
            Id = 1,
            MovieId = 1,
            GenreId = 2
        };

        MovieGenreMapping m2 = new()
        {
            Id = 2,
            MovieId = 1,
            GenreId = 3
        };

        MovieGenreMapping m3 = new()
        {
            Id = 3,
            MovieId = 2,
            GenreId = 1
        };

        MovieGenreMapping m4 = new()
        {
            Id = 4,
            MovieId = 2,
            GenreId = 2
        };

        MovieGenreMapping m5 = new()
        {
            Id = 5,
            MovieId = 2,
            GenreId = 9
        };

        MovieGenreMapping m6 = new()
        {
            Id = 6,
            MovieId = 3,
            GenreId = 3
        };

        MovieGenreMapping m7 = new()
        {
            Id = 7,
            MovieId = 4,
            GenreId = 2
        };

        MovieGenreMapping m8 = new()
        {
            Id = 8,
            MovieId = 4,
            GenreId = 3
        };

        MovieGenreMapping m9 = new()
        {
            Id = 9,
            MovieId = 5,
            GenreId = 3
        };

        MovieGenreMapping m10 = new()
        {
            Id = 10,
            MovieId = 5,
            GenreId = 4
        };

        MovieGenreMapping m11 = new()
        {
            Id = 11,
            MovieId = 1,
            GenreId = 5
        };

        MovieGenreMapping m12 = new()
        {
            Id = 12,
            MovieId = 1,
            GenreId = 9
        };

        MovieGenreMapping m13 = new()
        {
            Id = 13,
            MovieId = 4,
            GenreId = 9
        };

        MovieGenreMapping m14 = new()
        {
            Id = 14,
            MovieId = 3,
            GenreId = 5
        };

        MovieGenreMapping m15 = new()
        {
            Id = 15,
            MovieId = 3,
            GenreId = 9
        };

        MovieGenreMapping m16 = new()
        {
            Id = 16,
            MovieId = 4,
            GenreId = 5
        };

        modelBuilder.Entity<Genre>().HasData(comedy, drama, thriller, horror, action, retro, crime, biopic, fiction);
        modelBuilder.Entity<Movie>().HasData(avengers, piratesOfTheCaribbean, noWayHome, theMatrixResurrections, theConjuring);
        modelBuilder.Entity<MovieGenreMapping>().HasData(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16);
    }
}
