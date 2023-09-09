using Microsoft.EntityFrameworkCore;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Exceptions;
using Movies.API.Repositories.Interfaces;

namespace Movies.API.Repositories;

public class MoviesRepository : IMoviesRepository
{
    private readonly ApplicationDbContext context;
    public MoviesRepository(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task<List<Movie>> GetAllMovie(int page, int limit, SortColumn sortCol, SortDirection sortDir)
    {
        int skip = (page - 1) * limit;

        IQueryable<Movie> movieQueryable = context.Movies
            .Where(m => m.DeletedAt == null)
            .Include(m => m.Genres) // Populating public ICollection<MovieGenreMapping> Genres { get; set; } (Populate the mapping)
            .ThenInclude(mg => mg.Genre); // public Genre Genre { get; set; } (Populate each item in mapping)

        switch (sortCol)
        {
            case SortColumn.Title:
                movieQueryable = sortDir == SortDirection.Asc ? movieQueryable.OrderBy(x => x.Title) : movieQueryable.OrderByDescending(x => x.Title);
                break;
            case SortColumn.ReleaseYear:
                movieQueryable = sortDir == SortDirection.Asc ? movieQueryable.OrderBy(x => x.ReleaseYear) : movieQueryable.OrderByDescending(x => x.ReleaseYear);
                break;
            case SortColumn.RuntimeMinutes:
                movieQueryable = sortDir == SortDirection.Asc ? movieQueryable.OrderBy(x => x.RuntimeMinutes) : movieQueryable.OrderByDescending(x => x.RuntimeMinutes);
                break;
        }

        movieQueryable = movieQueryable
        .Skip(skip)
        .Take(limit);

        return await movieQueryable.ToListAsync();
    }

    public async Task<int> GetMovieCount()
    {
        return await context.Movies
            .Where(m => m.DeletedAt == null)
            .CountAsync();
    }

    public async Task<Movie> GetMovieById(int id)
    {
        return await context.Movies
            .Include(m => m.Genres)
            .ThenInclude(g => g.Genre)
            .FirstOrDefaultAsync(g => g.Id == id && g.DeletedAt == null);
    }

    public async Task<List<Movie>> SearchMovieByName(string term)
    {
        return await context.Movies
            .Where(m => m.DeletedAt == null && m.Title.Contains(term))
            .Include(m => m.Genres)
            .ThenInclude(mg => mg.Genre)
            .ToListAsync();
    }

    public Task<List<string>> GroupMoviesByGenreId(int id)
    {
        var movies = context.Movies
            .Where(m => m.DeletedAt == null)
            .Join(context.MovieGenreMappings.Where(mg => mg.GenreId == id), m => m.Id, mg => mg.MovieId, (m, mg) => m.Title);

        List<string> result = new();
        foreach (var movie in movies)
            result.Add(movie);

        return Task.FromResult(result);
    }

    public async Task<Movie> PostMovie(CreateMovieRequestDto movieRequestDto)
    {
        foreach (int gid in movieRequestDto.GenreIds)
        {
            if (await context.Genres.FirstOrDefaultAsync(g => g.Id == gid && g.DeletedAt == null) is null)
            {
                throw new InvalidGenreIdException("Invalid Genre Id(s)");
            }
        }

        Movie movie = new()
        {
            Title = movieRequestDto.Title.Trim(),
            ReleaseYear = movieRequestDto.ReleaseYear,
            RuntimeMinutes = movieRequestDto.RuntimeMinutes,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = null,
            DeletedAt = null
        };
        foreach (int gid in movieRequestDto.GenreIds)
        {
            context.MovieGenreMappings.Add(new MovieGenreMapping
            {
                Movie = movie,
                MovieId = movie.Id,
                Genre = await context.Genres.FirstOrDefaultAsync(g => g.Id == gid && g.DeletedAt == null),
                GenreId = gid
            });
        }
        context.Add(movie);

        await context.SaveChangesAsync();
        return movie;
    }

    public async Task<Movie> UpdateMovie(UpdateMovieRequestDto movieRequestDto)
    {
        Movie movie = await GetMovieById(movieRequestDto.Id);

        if (movie is null)
        {
            throw new MovieNotFoundException($"The movie with id {movieRequestDto.Id} does not exist!");
        }

        if ((movie.UpdatedAt is not null && movie.UpdatedAt.Value.Ticks / 1000000 != movieRequestDto.Timestamp / 1000000)
            || (movie.UpdatedAt is null && movie.CreatedAt.Ticks / 1000000 != movieRequestDto.Timestamp / 1000000))
        {
            throw new TimestampMismatchException("Timestamp does not match existing Movie's timestamp");
        }

        foreach (int gid in movieRequestDto.GenreIds)
        {
            if (await context.Genres.FirstOrDefaultAsync(g => g.Id == gid && g.DeletedAt == null) is null)
            {
                throw new InvalidGenreIdException("Invalid Genre Id(s)");
            }
        }

        context.MovieGenreMappings.RemoveRange(context.MovieGenreMappings.Where(mg => mg.MovieId == movieRequestDto.Id));

        movie.Title = movieRequestDto.Title.Trim();
        movie.ReleaseYear = movieRequestDto.ReleaseYear;
        movie.RuntimeMinutes = movieRequestDto.RuntimeMinutes;
        movie.UpdatedAt = DateTime.UtcNow;
        foreach (int gid in movieRequestDto.GenreIds)
        {
            movie.Genres.Add(new MovieGenreMapping
            {
                Movie = movie,
                MovieId = movie.Id,
                Genre = await context.Genres.FirstOrDefaultAsync(g => g.Id == gid && g.DeletedAt == null),
                GenreId = gid
            });
        }

        await context.SaveChangesAsync();
        return movie;
    }

    public async Task<Movie> DeleteMovieById(int id)
    {
        Movie movie = await GetMovieById(id);

        if (movie is null)
        {
            throw new MovieNotFoundException($"The movie with id {id} does not exist!");
        }

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
        {
            throw new MovieNotFoundException($"The movie with id {id} is not deleted!");
        }

        movie.DeletedAt = null;
        movie.UpdatedAt = DateTime.UtcNow;

        await context.SaveChangesAsync();
        return movie;
    }
}