using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Exceptions;
using Movies.API.Services.Interfaces;
using Newtonsoft.Json;

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
        int limit = 100,
        SortColumn sortCol = SortColumn.ReleaseYear,
        SortDirection sortDir = SortDirection.Desc)
    {
        try
        {
            if (limit < 1 || limit > 100)
            {
                throw new InvalidPageLimitException("Limit per page must be between 1 and 100.");
            }

            int totalItems = await movieService.GetMovieCount();
            int lastPageNumber = (int)Math.Ceiling((float)totalItems / limit);

            if (lastPageNumber == 1 && page > lastPageNumber)
            {
                throw new InvalidPageNumberException("Page number must be 1.");
            }

            if (page < 1 || page > lastPageNumber)
            {
                throw new InvalidPageNumberException($"Page number must be between 1 and {lastPageNumber}.");
            }

            List<Movie> movies = await movieService.GetAllMovie(page, limit, sortCol, sortDir);

            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(new
            {
                first_page = "https://" + Request.Host + Request.Path + "?page=1&limit=" + limit,
                last_page = "https://" + Request.Host.Value + Request.Path + "?page=" + lastPageNumber + "&limit=" + limit,
                prev_page = page != 1 ? "https://" + Request.Host.Value + Request.Path + "?page=" + (page - 1) + "&limit=" + limit : null,
                next_page = page < lastPageNumber ? "https://" + Request.Host.Value + Request.Path + "?page=" + (page + 1) + "&limit=" + limit : null,
                total_items = totalItems
            }));

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