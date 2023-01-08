using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Exceptions;
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
        try
        {
            List<Genre> genres = await genreService.GetAllGenre();

            return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(genres));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetGenreById(int id)
    {
        try
        {
            Genre genre = await genreService.GetGenreById(id);
            return Ok(mapper.Map<GenreResponseDto>(genre));
        }
        catch (InvalidGenreIdException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (GenreNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("Search")]
    public async Task<ActionResult> SearchGenreByName(string term)
    {
        try
        {
            List<Genre> matchingGenres = await genreService.SearchGenreByName(term);

            return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(matchingGenres));
        }
        catch (InvalidSearchTermException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (GenreNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("Timestamps")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<ActionResult> GetAllGenreTimestamps()
    {
        try
        {
            List<Genre> genres = await genreService.GetAllGenreTimestamps();

            return Ok(genres);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("Delete/{id:int}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<ActionResult> DeleteGenreById(int id)
    {
        try
        {
            await genreService.DeleteGenreById(id);

            return Ok($"Successfully deleted genre with id {id}!");
        }
        catch (InvalidGenreIdException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (GenreNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("Restore/{id:int}")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public async Task<ActionResult> RestoreGenreById(int id)
    {
        try
        {
            await genreService.RestoreGenreById(id);

            return Ok($"Successfully restored genre with id {id}!");
        }
        catch (InvalidGenreIdException ex)
        {
            return BadRequest(ex.Message);
        }
        catch (GenreNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}