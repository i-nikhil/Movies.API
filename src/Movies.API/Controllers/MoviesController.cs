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

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetMovieById(int id)
    {
        Movie movie = await movieService.GetMovieById(id);
        return Ok(mapper.Map<MovieResponseDto>(movie));
    }

    [HttpGet("Search")]
    public async Task<ActionResult> SearchMovieByName(string term)
    {
        List<Movie> movies = await movieService.SearchMovieByName(term);
        return Ok(mapper.Map<IEnumerable<MovieResponseDto>>(movies));
    }

    [HttpGet("GroupByGenre")]
    public async Task<ActionResult> GroupMoviesByGenreId(int id)
    {
        var movies = await movieService.GroupMoviesByGenreId(id);
        return Ok(movies);
    }

    [HttpPost("Create")]
    public async Task<ActionResult> PostMovie(CreateMovieRequestDto movieRequestDto)
    {
        Movie movie = await movieService.PostMovie(movieRequestDto);
        return Ok(mapper.Map<MovieResponseDto>(movie));
    }

    [HttpPut("Update")]
    public async Task<ActionResult> UpdateMovie(UpdateMovieRequestDto movieRequestDto)
    {
        Movie updatedMovie = await movieService.UpdateMovie(movieRequestDto);
        return Ok(mapper.Map<MovieResponseDto>(updatedMovie));
    }

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteMovieById(int id)
    {
        await movieService.DeleteMovieById(id);
        return Ok($"Successfully deleted movie with id {id}!");
    }

    [HttpPut("Restore/{id:int}")]
    public async Task<ActionResult> RestoreMovieById(int id)
    {
        await movieService.RestoreMovieById(id);
        return Ok($"Successfully restored movie with id {id}!");
    }
}