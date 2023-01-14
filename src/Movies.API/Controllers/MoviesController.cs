using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Exceptions;
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
    public async Task<ActionResult> GetAllMovie(
        int page = 1,
        int limit = 1000,
        SortColumn sortCol = SortColumn.ReleaseYear,
        SortDirection sortDir = SortDirection.Desc)
    {
        try
        {
            List<Movie> movies = await movieService.GetAllMovie(page, limit, sortCol, sortDir);
            return Ok(mapper.Map<IEnumerable<MovieResponseDto>>(movies));
        }
        catch (Exception ex)
        {
            return HandleExceptions(ex);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetMovieById(int id)
    {
        try
        {
            Movie movie = await movieService.GetMovieById(id);
            return Ok(mapper.Map<MovieResponseDto>(movie));
        }
        catch (Exception ex)
        {
            return HandleExceptions(ex);
        }
    }

    [HttpGet("Search")]
    public async Task<ActionResult> SearchMovieByName(string term)
    {
        try
        {
            List<Movie> movies = await movieService.SearchMovieByName(term);
            return Ok(mapper.Map<IEnumerable<MovieResponseDto>>(movies));
        }
        catch (Exception ex)
        {
            return HandleExceptions(ex);
        }
    }

    [HttpGet("GroupByGenre")]
    public async Task<ActionResult> GroupMoviesByGenreId(int id)
    {
        try
        {
            var movies = await movieService.GroupMoviesByGenreId(id);
            return Ok(movies);
        }
        catch (Exception ex)
        {
            return HandleExceptions(ex);
        }
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostMovie(CreateMovieRequestDto movieRequestDto)
    {
        try
        {
            Movie movie = await movieService.PostMovie(movieRequestDto);
            return Ok(mapper.Map<MovieResponseDto>(movie));
        }
        catch (Exception ex)
        {
            return HandleExceptions(ex);
        }
    }

    [HttpPut("Update")]
    public async Task<ActionResult> UpdateMovie(UpdateMovieRequestDto movieRequestDto)
    {
        try
        {
            Movie updatedMovie = await movieService.UpdateMovie(movieRequestDto);
            return Ok(mapper.Map<MovieResponseDto>(updatedMovie));
        }
        catch (Exception ex)
        {
            return HandleExceptions(ex);
        }
    }

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteMovieById(int id)
    {
        try
        {
            await movieService.DeleteMovieById(id);
            return Ok($"Successfully deleted movie with id {id}!");
        }
        catch (Exception ex)
        {
            return HandleExceptions(ex);
        }
    }

    [HttpPut("Restore/{id:int}")]
    public async Task<ActionResult> RestoreMovieById(int id)
    {
        try
        {
            await movieService.RestoreMovieById(id);
            return Ok($"Successfully restored movie with id {id}!");
        }
        catch (Exception ex)
        {
            return HandleExceptions(ex);
        }
    }

    private ActionResult HandleExceptions(Exception ex)
    {
        switch (ex)
        {
            case MovieNotFoundException: return NotFound(ex.Message);
            case InvalidPageNumberException:
            case InvalidPageLimitException:
            case InvalidMovieIdException:
            case InvalidGenreIdException:
            case InvalidSearchTermException:
            case TimestampMismatchException:
            default: return BadRequest(ex.Message);
        }
    }
}