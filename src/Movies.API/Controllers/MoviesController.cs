using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Services.Interfaces;

namespace Movies.API.Controllers;

[ApiController]
[Route("Movies")]
public class MoviesController : ControllerBase
{
    private readonly IMoviesService movieService;
    private readonly IMapper mapper;
    public MoviesController(IMoviesService movieService, IMapper mapper)
    {
        this.movieService = movieService;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult> GetAllMovie()
    {
        List<Movie> movies = await movieService.GetAllMovie();

        return Ok(mapper.Map<IEnumerable<MovieResponseDto>>(movies));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetMovieById(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid Movie Id");
        }

        Movie movie = await movieService.GetMovieById(id);

        if (movie is null)
        {
            return NotFound($"The movie with id {id} does not exist!");
        }

        return Ok(mapper.Map<MovieResponseDto>(movie));
    }

    [HttpGet("Search")]
    public async Task<ActionResult> SearchMovieByName(string term)
    {
        if (string.IsNullOrEmpty(term) || string.IsNullOrWhiteSpace(term))
        {
            return BadRequest("Search term cannot be empty");
        }

        List<Movie> movies = await movieService.SearchMovieByName(term.Trim());

        if (movies.Count == 0)
        {
            return NotFound($"No matching movie found!");
        }

        return Ok(mapper.Map<IEnumerable<MovieResponseDto>>(movies));
    }

    [HttpGet("GroupByGenre")]
    public async Task<ActionResult> GroupMoviesByGenreId(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid Movie Id");
        }

        var movies = await movieService.GroupMoviesByGenreId(id);

        if (movies.Count == 0)
        {
            return NotFound($"No movie found!");
        }

        return Ok(movies);
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostMovie(MovieRequestDto movieRequestDto)
    {
        //add check to match existing title

        Movie movie = await movieService.PostMovie(movieRequestDto);

        if (movie is null)
        {
            return NotFound("Invalid Genre Id(s)");
        }

        return Ok(mapper.Map<MovieResponseDto>(movie));
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
        Movie movie = await movieService.DeleteMovieById(id);

        if (movie is null)
        {
            return NotFound($"The movie with id {id} does not exist!");
        }

        return Ok($"Successfully deleted movie with id {id}!");
    }

    [HttpPut("Restore/{id:int}")]
    public async Task<ActionResult> RestoreMovieById(int id)
    {
        Movie movie = await movieService.RestoreMovieById(id);

        if (movie is null)
        {
            return NotFound($"The movie with id {id} is not deleted!");
        }

        return Ok($"Successfully restored movie with id {id}!");
    }
}