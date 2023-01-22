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
    public GenresController(IGenresService genreService, IMapper mapper)
    {
        this.genreService = genreService;
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
        Genre genre = await genreService.GetGenreById(id);
        return Ok(mapper.Map<GenreResponseDto>(genre));
    }

    [HttpGet("Search")]
    public async Task<ActionResult> SearchGenreByName(string term)
    {
        List<Genre> matchingGenres = await genreService.SearchGenreByName(term);
        return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(matchingGenres));
    }

    [HttpGet("Timestamps")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<ActionResult> GetAllGenreTimestamps()
    {
        List<Genre> genres = await genreService.GetAllGenreTimestamps();
        return Ok(genres);
    }

    [HttpDelete("Delete/{id:int}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<ActionResult> DeleteGenreById(int id)
    {
        await genreService.DeleteGenreById(id);
        return Ok($"Successfully deleted genre with id {id}!");
    }

    [HttpPut("Restore/{id:int}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<ActionResult> RestoreGenreById(int id)
    {
        await genreService.RestoreGenreById(id);
        return Ok($"Successfully restored genre with id {id}!");
    }
}