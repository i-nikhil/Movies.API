using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Services.Interfaces;

namespace Movies.API.Controllers;

/// <summary>
/// The Genre Controller empowers users to seamlessly explore, find, and access movie genres in your application. It facilitates actions like accessing the full genre list, searching for genres by name, and delving into specific genre details, making it a crucial component for genre-related interactions.
/// </summary>
[ApiController]
[Route("Genres")]
public class GenresController : ControllerBase
{
    private readonly IGenresService genreService;
    private readonly IMapper mapper;

    /// <summary>
    /// Parameterized constructor of GenresController.
    /// </summary>
    /// <param name="genreService"></param>
    /// <param name="mapper"></param>
    public GenresController(IGenresService genreService, IMapper mapper)
    {
        this.genreService = genreService;
        this.mapper = mapper;
    }

    /// <summary>
    /// Retrieves the list of all genres along with their respective IDs.
    /// </summary>
    /// <returns>List of all genres.</returns>
    /// <response code="200">JSON response having list of all genres.</response>
    [HttpGet]
    public async Task<ActionResult> GetAllGenre()
    {
        List<Genre> genres = await genreService.GetAllGenre();
        return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(genres));
    }

    /// <summary>
    /// Retrieves a specific genre by its unique ID.
    /// </summary>
    /// <param name="id">Unique ID of the genre.</param>
    /// <returns>Specific genre details.</returns>
    /// <response code="200">JSON response having specific genre details.</response>
    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetGenreById(int id)
    {
        Genre genre = await genreService.GetGenreById(id);
        return Ok(mapper.Map<GenreResponseDto>(genre));
    }

    /// <summary>
    /// Searches genres matching by its name.
    /// </summary>
    /// <param name="term">Keyword based on which genre needs to be searched.</param>
    /// <returns>List of matching genres.</returns>
    /// <response code="200">JSON response having list of matching genres.</response>
    [HttpGet("Search")]
    public async Task<ActionResult> SearchGenreByName(string term)
    {
        List<Genre> matchingGenres = await genreService.SearchGenreByName(term);
        return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(matchingGenres));
    }

    /// <summary>
    /// Internal endpoint to get the created, updated and deleted timestamps for each genre.
    /// </summary>
    /// <returns>Timestamp detials for all genres.</returns>
    /// <response code="200">JSON response having timestamp detials for all genres.</response>
    [HttpGet("Timestamps")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<ActionResult> GetAllGenreTimestamps()
    {
        List<Genre> genres = await genreService.GetAllGenreTimestamps();
        return Ok(genres);
    }
}