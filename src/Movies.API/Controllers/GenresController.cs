using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Services.Interfaces;

namespace Movies.API.Controllers;

[ApiController]
[Route("Genres")]
public class GenresController : ControllerBase
{
    private readonly IGenresService genreService;
    private readonly IMapper mapper;
    public GenresController(IGenresService genresService, IMapper mapper)
    {
        this.genreService = genresService;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult> GetAllGenre()
    {
        List<Genre> genres = await genreService.GetAllGenre();

        return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(genres));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetGenreById(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid Genre Id");
        }

        Genre genre = await genreService.GetGenreById(id);

        if (genre is null)
        {
            return NotFound($"The genre with id {id} does not exist!");
        }

        return Ok(mapper.Map<GenreResponseDto>(genre));
    }

    [HttpGet("Search")]
    public async Task<ActionResult> SearchGenreByName(string term)
    {
        if (string.IsNullOrEmpty(term) || string.IsNullOrWhiteSpace(term))
        {
            return BadRequest("Search term cannot be empty");
        }

        List<Genre> matchingGenres = await genreService.SearchGenreByName(term.Trim());

        if (matchingGenres.Count == 0)
        {
            return NotFound($"No matching genre found!");
        }

        return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(matchingGenres));
    }

    [HttpGet("Timestamps")]
    public async Task<ActionResult> GetAllGenreTimestamps()
    {
        List<Genre> genres = await genreService.GetAllGenreTimestamps();

        return Ok(genres);
    }

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteGenreById(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid Genre Id");
        }

        Genre genre = await genreService.DeleteGenreById(id);

        if (genre is null)
        {
            return NotFound($"The genre with id {id} does not exist!");
        }

        return Ok($"Successfully deleted genre with id {id}!");
    }

    [HttpPut("Restore/{id:int}")]
    public async Task<ActionResult> RestoreGenreById(int id)
    {
        if (id <= 0)
        {
            return BadRequest("Invalid Genre Id");
        }

        Genre genre = await genreService.RestoreGenreById(id);

        if (genre is null)
        {
            return NotFound($"The genre with id {id} is not deleted!");
        }

        return Ok($"Successfully restored genre with id {id}!");
    }
}