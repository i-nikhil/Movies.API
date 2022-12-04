using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Repositories.Interfaces;

namespace Movies.API.Repositories;

public class MoviesRepository : IMoviesRepository
{
    private readonly ApplicationDbContext context;
    public MoviesRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<List<Movie>> GetAllMovie()
    {
        return await context.Movies
            .Where(g => g.DeletedAt == null)
            .Include(m => m.Genres) // Populating public ICollection<MovieGenreMapping> Genres { get; set; } (Populate the mapping)
            .ThenInclude(g => g.Genre) // public Genre Genre { get; set; } (Populate each item in mapping)
            .OrderByDescending(m => m.ReleaseYear)
            .ToListAsync();
    }

    public async Task<Movie> GetMovieById(int id)
    {
        return await context.Movies
            .Include(m => m.Genres)
            .ThenInclude(g => g.Genre)
            .FirstOrDefaultAsync(g => g.Id == id && g.DeletedAt == null);
    }

    public async Task PostMovie(MovieRequestDto movieRequestDto)
    {
        Movie movie = new()
        {
            Title = movieRequestDto.Title,
            ReleaseYear = movieRequestDto.ReleaseYear,
            RuntimeMinutes = movieRequestDto.RuntimeMinutes,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };

        context.Add(movie);

        foreach (int gid in movieRequestDto.GenreIds)
        {
            context.MovieGenreMappings.Add(new MovieGenreMapping
            {
                Movie = movie,
                MovieId = movie.Id,
                Genre = await context.Genres.FirstOrDefaultAsync(g => g.Id == movie.Id && g.DeletedAt == null),
                GenreId = gid
            });
        }

        await context.SaveChangesAsync();
    }

    public async Task<Movie> DeleteMovieById(int id)
    {
        Movie movie = await GetMovieById(id);

        if (movie is null)
            return movie;

        movie.DeletedAt = DateTime.UtcNow;
        movie.UpdatedAt = DateTime.UtcNow;
        await context.SaveChangesAsync();
        return movie;
    }

    public async Task<Movie> RestoreMovieById(int id)
    {
        Movie movie = await context.Movies
                .FirstOrDefaultAsync(m => m.Id == id && m.DeletedAt != null);

        if (movie is null)
            return movie;

        movie.DeletedAt = null;
        movie.UpdatedAt = DateTime.UtcNow;
        await context.SaveChangesAsync();
        return movie;
    }
}