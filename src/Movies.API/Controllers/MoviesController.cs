using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Exceptions;
using Movies.API.Services.Interfaces;
using Newtonsoft.Json;

namespace Movies.API.Controllers;

/// <summary>
/// The Movies Controller manages movie-related actions in a web app, including getting movie details, searching by name, categorizing by genre, deleting, and restoring movies.It interfaces with the movie database for seamless operation.
/// </summary>
[ApiController]
[Route("Movies")]
public class MoviesController : ControllerBase
{
    private readonly IMoviesService movieService;
    private readonly IMapper mapper;

    /// <summary>
    /// Parameterized constructor of GenresController.
    /// </summary>
    /// <param name="movieService"></param>
    /// <param name="mapper"></param>
    public MoviesController(IMoviesService movieService, IMapper mapper)
    {
        this.movieService = movieService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Retrieves the paginated list of archived movies along with their details.
    /// </summary>
    /// <param name="page">Page number of the movie list.</param>
    /// <param name="limit">Number of movies to be listed per page.</param>
    /// <param name="sortColumn">Field based on which movies needs to be sorted. Possible values: 0 - Title, 1 - Release Year, 2 - Runtime Minutes.</param>
    /// <param name="sortDirection">Sorting order of the field selected. Possible values: 0 - Ascending, 1 - Descending.</param>
    /// <returns>List of movies in a paginated order.</returns>
    /// <response code="200">JSON response having list of movies in a paginated order.</response>
    /// <exception cref="InvalidPageLimitException"></exception>
    /// <exception cref="InvalidPageNumberException"></exception>
    [HttpGet]
    public async Task<ActionResult> GetAllMovie(
        int page = 1,
        int limit = 100,
        SortColumn sortColumn = SortColumn.ReleaseYear,
        SortDirection sortDirection = SortDirection.Desc)
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

        List<Movie> movies = await movieService.GetAllMovie(page, limit, sortColumn, sortDirection);

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

    /// <summary>
    /// Retrieves a specific movie by its unique ID.
    /// </summary>
    /// <param name="id">Unique ID of the movie.</param>
    /// <returns>Specific movie details.</returns>
    /// <response code="200">JSON response having specific movie details.</response>
    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetMovieById(int id)
    {
        Movie movie = await movieService.GetMovieById(id);
        return Ok(mapper.Map<MovieResponseDto>(movie));
    }

    /// <summary>
    /// Searches movies matching by its name.
    /// </summary>
    /// <param name="term">Keyword based on which movie needs to be searched.</param>
    /// <returns>List of matching movies.</returns>
    /// <response code="200">JSON response having list of matching movies.</response>
    [HttpGet("Search")]
    public async Task<ActionResult> SearchMovieByName(string term)
    {
        List<Movie> movies = await movieService.SearchMovieByName(term);
        return Ok(mapper.Map<IEnumerable<MovieResponseDto>>(movies));
    }

    /// <summary>
    /// Groups the names of movie based on a specific genre.
    /// </summary>
    /// <param name="id">Unique ID of the genre. Tip: Hit the get all genres endpoint to find the id of a specific genre.</param>
    /// <returns>Mmovies grouped by specific genre.</returns>
    /// <response code="200">JSON response having movies grouped by specific genre.</response>
    [HttpGet("GroupByGenre")]
    public async Task<ActionResult> GroupMoviesByGenreId(int id)
    {
        List<string> movies = await movieService.GroupMoviesByGenreId(id);
        return Ok(movies);
    }

    /// <summary>
    /// Archives a movie related details in the database.
    /// </summary>
    /// <param name="movieRequestDto">JSON request body having details for the movie to be archived.</param>
    /// <returns>Created movie details along with its new ID and created timestamp.</returns>
    /// <response code="200">JSON response having created movie details along with its new ID and created timestamp.</response>
    [HttpPost("Create")]
    public async Task<ActionResult> PostMovie(CreateMovieRequestDto movieRequestDto)
    {
        Movie movie = await movieService.PostMovie(movieRequestDto);
        return Ok(mapper.Map<MovieResponseDto>(movie));
    }

    /// <summary>
    /// Modify and update details for an archived movie.
    /// </summary>
    /// <param name="movieRequestDto">JSON request body having details for the movie to be updated.</param>
    /// <returns>Updated movie details along with its ID and updated timestamp.</returns>
    /// <response code="200">JSON response having updated movie details along with its ID and updated timestamp.</response>
    [HttpPut("Update")]
    public async Task<ActionResult> UpdateMovie(UpdateMovieRequestDto movieRequestDto)
    {
        Movie updatedMovie = await movieService.UpdateMovie(movieRequestDto);
        return Ok(mapper.Map<MovieResponseDto>(updatedMovie));
    }

    /// <summary>
    /// Soft deletes a movie details from the database by its unique ID.
    /// </summary>
    /// <param name="id">Unique ID of the movie.</param>
    /// <returns>Message asserting successful deletion.</returns>
    /// <response code="200">String message asserting successful deletion.</response>
    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteMovieById(int id)
    {
        await movieService.DeleteMovieById(id);
        return Ok($"Successfully deleted movie with id {id}!");
    }

    /// <summary>
    /// Restores the soft deleted movie details from the database by its unique ID.
    /// </summary>
    /// <param name="id">Unique ID of the movie.</param>
    /// <returns>Message asserting successful restoration.</returns>
    /// <response code="200">String message asserting successful restoration.</response>
    [HttpPut("Restore/{id:int}")]
    public async Task<ActionResult> RestoreMovieById(int id)
    {
        await movieService.RestoreMovieById(id);
        return Ok($"Successfully restored movie with id {id}!");
    }
}