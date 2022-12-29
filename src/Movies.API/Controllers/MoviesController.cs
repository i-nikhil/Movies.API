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
    public async Task<ActionResult> GetAllMovie(int page = 1,
        int limit = 1000,
        SortColumn sortCol = SortColumn.ReleaseYear,
        SortDirection sortDir = SortDirection.Desc)
    {
        List<Movie> movies = await movieService.GetAllMovie(page, limit, sortCol, sortDir);

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
    public async Task<ActionResult> PostMovie(CreateMovieRequestDto movieRequestDto)
    {
        Movie movie = await movieService.PostMovie(movieRequestDto);

        if (movie is null)
        {
            return NotFound("Invalid Genre Id(s)");
        }

        return Ok(mapper.Map<MovieResponseDto>(movie));
    }

    [HttpPut("Update")]
    public async Task<ActionResult> UpdateMovie(UpdateMovieRequestDto movieRequestDto)
    {
        if (movieRequestDto.Id <= 0)
        {
            return BadRequest("Invalid Movie Id");
        }

        Movie movie = await movieService.GetMovieById(movieRequestDto.Id);

        if (movie is null)
        {
            return NotFound($"Movie with id {movieRequestDto.Id} does not exist!");
        }

        if((movie.UpdatedAt is not null && movie.UpdatedAt.Value.Ticks != movieRequestDto.Timestamp)
            || (movie.UpdatedAt is null && movie.CreatedAt.Ticks != movieRequestDto.Timestamp))
        {
            return BadRequest("Invalid Timestamp");
        }

        Movie updatedMovie = await movieService.UpdateMovie(movieRequestDto);

        if (updatedMovie is null)
        {
            return NotFound("Invalid Genre Id(s)");
        }

        return Ok(mapper.Map<MovieResponseDto>(updatedMovie));
    }

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