using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Domain.DTOs;
using Movies.Domain.Entities;
using Movies.Infrastructure;

namespace Movies.API.Controllers;

[ApiController]
[Route("Movies")]
public class MoviesController : ControllerBase
{
    private readonly ApplicationDbContext context;
    private readonly IMapper mapper;
    public MoviesController(ApplicationDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult> GetAllMovie()
    {
        List<Movie> movies = await context.Movies
            .Where(g => g.DeletedAt == null)
            .Include(m => m.Genres) // Populating public ICollection<MovieGenreMapping> Genres { get; set; } (Populate the mapping)
            .ThenInclude(g => g.Genre) // public Genre Genre { get; set; } (Populate each item in mapping)
            .OrderByDescending(m => EF.Property<DateTime>(m, "CreatedAt"))
            .ToListAsync();

        return Ok(mapper.Map<IEnumerable<MovieResponseDto>>(movies));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetMovieById(int id)
    {
        Movie movie = await context.Movies
            .Include(m => m.Genres)
            .ThenInclude(g => g.Genre)
            .FirstOrDefaultAsync(g => g.Id == id && g.DeletedAt == null);

        if (movie is null)
        {
            return NotFound($"The movie with id {id} does not exist!");
        }

        return Ok(mapper.Map<MovieResponseDto>(movie));
    }

    [HttpGet("Search")]
    public async Task<ActionResult> SearchMovieByName(string term)
    {
        List<Movie> movies = await context.Movies
            .Where(m => m.DeletedAt == null)
            .Include(m => m.Genres)
            .ThenInclude(g => g.Genre)
            .ToListAsync();

        List<Movie> matchingMovies = new();

        foreach (var movie in movies)
        {
            if (movie.Title.Contains(term, StringComparison.CurrentCultureIgnoreCase))
                matchingMovies.Add(movie);
        }

        if (matchingMovies.Count == 0)
        {
            return NotFound($"No matching movie found!");
        }

        return Ok(mapper.Map<IEnumerable<MovieResponseDto>>(matchingMovies));
    }

    //[HttpGet("GroupByGenre")]
    //public async Task<ActionResult> GroupMovieByGenre()
    //{
    //    var movies = await context.Movies
    //        .Where(g => g.DeletedAt == null)
    //        .GroupBy(g => g.Genres)
    //        .ToListAsync();

    //    return Ok(movies);
    //}

    [HttpPost("Create")]
    public async Task<ActionResult> PostMovie(MovieRequestDto movieRequestDto)
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
        return Ok();
    }

    //[HttpPut("Update/{id:int}")]
    //public async Task<ActionResult> UpdateMovie(int id, MovieRequestDto movieRequestDto)
    //{
    //    Movie movie = await context.Movies
    //        .Include(m => m.Genres)
    //        .ThenInclude(g => g.Genre)
    //        .FirstOrDefaultAsync(g => g.Id == id);

    //    movie.Title = movieRequestDto.Title;
    //        ReleaseYear = movieRequestDto.ReleaseYear,
    //        RuntimeMinutes = movieRequestDto.RuntimeMinutes,
    //        CreatedAt = DateTime.UtcNow,
    //        UpdatedAt = null,
    //        DeletedAt = null
    //    };
    //    context.Add(movie);

    //    foreach (int gid in movieRequestDto.GenreIds)
    //    {
    //        context.MovieGenreMappings.Add(new MovieGenreMapping
    //        {
    //            Movie = movie,
    //            MovieId = movie.Id,
    //            Genre = await context.Genres.FirstOrDefaultAsync(g => g.Id == movie.Id && g.DeletedAt == null),
    //            GenreId = gid
    //        });
    //    }

    //    await context.SaveChangesAsync();
    //    return Ok();
    //}

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteMovieById(int id)
    {
        Movie movie = await context.Movies
            .FirstOrDefaultAsync(g => g.Id == id);

        if (movie is null)
        {
            return NotFound($"The movie with id {id} does not exist!");
        }

        if (movie.DeletedAt is not null)
        {
            return NotFound($"The movie with id {id} is already deleted at {movie.DeletedAt}!");
        }

        movie.DeletedAt = DateTime.UtcNow;
        movie.UpdatedAt = DateTime.UtcNow;
        await context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("Restore/{id:int}")]
    public async Task<ActionResult> RestoreMovieById(int id)
    {
        Movie movie = await context.Movies
            .FirstOrDefaultAsync(g => g.Id == id);

        if (movie is null)
        {
            return NotFound($"The movie with id {id} does not exist!");
        }

        if (movie.DeletedAt is null)
        {
            return NotFound($"The movie with id {id} is not deleted!");
        }

        movie.DeletedAt = null;
        movie.UpdatedAt = DateTime.UtcNow;
        await context.SaveChangesAsync();

        return Ok();
    }
}
