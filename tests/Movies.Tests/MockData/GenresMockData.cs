using Movies.API.Entities;

namespace Movies.UnitTest.MockData
{
    public static class GenresMockData
    {
        public static List<Genre> GetGenres()
        {
            return new List<Genre>
            {
                new Genre()
                {
                    Id = 1,
                    Name = GenreName.Comedy,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null,
                    DeletedAt = null
                },
                new Genre()
                {
                    Id = 2,
                    Name = GenreName.Drama,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null,
                    DeletedAt = null
                },
                new Genre()
                {
                    Id = 3,
                    Name = GenreName.Thriller,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = null,
                    DeletedAt = null
                }
            };
        }
    }
}