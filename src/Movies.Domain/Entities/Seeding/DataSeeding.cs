using Microsoft.EntityFrameworkCore;

namespace Movies.Domain.Entities.Seeding
{
    public static class DataSeeding
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            Movie avengers = new()
            {
                Id = 1,
                Title = "Avengers",
                ReleaseYear = 2012,
                RuntimeMinutes = 143,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                DeletedAt = null
            };

            Movie piratesOfTheCaribbean = new()
            {
                Id = 2,
                Title = "Pirates of the Caribbean",
                ReleaseYear = 2003,
                RuntimeMinutes = 143,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                DeletedAt = null
            };

            Movie noWayHome = new()
            {
                Id = 3,
                Title = "Spider-Man: No way home",
                ReleaseYear = 2022,
                RuntimeMinutes = 148,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                DeletedAt = null
            };

            Movie theMatrixResurrections = new()
            {
                Id = 4,
                Title = "The Matrix Resurrections",
                ReleaseYear = 2021,
                RuntimeMinutes = 148,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                DeletedAt = null
            };

            Movie theConjuring = new()
            {
                Id = 5,
                Title = "The Conjuring",
                ReleaseYear = 2013,
                RuntimeMinutes = 112,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                DeletedAt = null
            };

            Genre comedy = new()
            {
                Id = 1,
                Name = GenreName.Comedy,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                DeletedAt = null
            };

            Genre drama = new()
            {
                Id = 2,
                Name = GenreName.Drama,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                DeletedAt = null
            };

            Genre thriller = new()
            {
                Id = 3,
                Name = GenreName.Thriller,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                DeletedAt = null
            };

            Genre horror = new()
            {
                Id = 4,
                Name = GenreName.Horror,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
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
                GenreId = 3
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

            modelBuilder.Entity<Movie>().HasData(avengers, piratesOfTheCaribbean, noWayHome, theMatrixResurrections, theConjuring);
            modelBuilder.Entity<Genre>().HasData(comedy, drama, thriller, horror);
            modelBuilder.Entity<MovieGenreMapping>().HasData(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10);
        }
    }
}
