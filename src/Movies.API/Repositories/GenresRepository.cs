using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using Movies.API.Entities;
using Movies.API.Exceptions;
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

        public async Task<List<Genre>> SearchGenreByName(string term)//to be fixed
        {
            return await context.Genres
            .Where(g => g.DeletedAt == null && g.Name.GetDisplayName().Contains(term))
            .ToListAsync();
        }

        public async Task<List<Genre>> GetAllGenreTimestamps()
        {
            return await context.Genres
                .ToListAsync();
        }
    }
}