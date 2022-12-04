using Microsoft.EntityFrameworkCore;
using Movies.API.Entities;
using Movies.API.Repositories.Interfaces;

namespace Movies.API.Repositories
{
    public class GenresRepository : IGenresRepository
    {
        private readonly ApplicationDbContext context;
        public GenresRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<List<Genre>> GetAllGenre()
        {
            return await context.Genres
                .Where(g => g.DeletedAt == null)
                .ToListAsync();
        }

        public async Task<Genre> GetGenreById(int id)
        {
            return await context.Genres
                .FirstOrDefaultAsync(g => g.Id == id && g.DeletedAt == null);
        }

        public async Task<List<Genre>> GetAllGenreTimestamps()
        {
            return await context.Genres
                .ToListAsync();
        }

        public async Task<Genre> DeleteGenreById(int id)
        {
            Genre genre = await GetGenreById(id);

            if (genre is null)
                return genre;

            genre.DeletedAt = DateTime.UtcNow;
            genre.UpdatedAt = DateTime.UtcNow;
            await context.SaveChangesAsync();
            return genre;
        }

        public async Task<Genre> RestoreGenreById(int id)
        {
            Genre genre = await context.Genres
                .FirstOrDefaultAsync(g => g.Id == id && g.DeletedAt != null);

            if (genre is null)
                return genre;

            genre.DeletedAt = null;
            genre.UpdatedAt = DateTime.UtcNow;
            await context.SaveChangesAsync();
            return genre;
        }
    }
}