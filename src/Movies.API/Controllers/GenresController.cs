using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.API.DTOs;
using Movies.API.Entities;

namespace Movies.API.Controllers;

[ApiController]
[Route("Genres")]
public class GenresController : ControllerBase
{
    private readonly ApplicationDbContext context;
    private readonly IMapper mapper;
    public GenresController(ApplicationDbContext context, IMapper mapper)
    {
        this.context = context;
        this.mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult> GetAllGenre()
    {
        List<Genre> genres =  await context.Genres
            .Where(g => g.DeletedAt == null)
            .ToListAsync();

        return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(genres));
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult> GetGenreById(int id)
    {
        Genre genre = await context.Genres
            .FirstOrDefaultAsync(g => g.Id == id && g.DeletedAt == null);

        if (genre is null)
        {
            return NotFound($"The genre with id {id} does not exist!");
        }

        return Ok(mapper.Map<GenreResponseDto>(genre));
    }

    [HttpGet("Search")]
    public async Task<ActionResult> SearchGenreByName(string term)
    {
        List<Genre> genres = await context.Genres
            .Where(g =>  g.DeletedAt == null)
            //.Where(g => g.Name.ToString().Contains(term))
            .ToListAsync();

        List<Genre> matchingGenres = new();

        foreach(var genre in genres)
        {
            if (genre.Name.ToString().Contains(term, StringComparison.CurrentCultureIgnoreCase))
                matchingGenres.Add(genre);
        }

        if (matchingGenres.Count == 0)
        {
            return NotFound($"No matching genre found!");
        }

        return Ok(mapper.Map<IEnumerable<GenreResponseDto>>(matchingGenres));
    }

    [HttpGet("Timestamps")]
    public async Task<ActionResult> GetAllGenreTimestamps()
    {
        List<Genre> genres = await context.Genres
            .ToListAsync();

        return Ok(genres);
    }

    [HttpDelete("Delete/{id:int}")]
    public async Task<ActionResult> DeleteGenreById(int id)
    {
        Genre genre = await context.Genres
            .FirstOrDefaultAsync(g => g.Id == id);

        if (genre is null)
        {
            return NotFound($"The genre with id {id} does not exist!");
        }

        if (genre.DeletedAt is not null)
        {
            return NotFound($"The genre with id {id} is already deleted at {genre.DeletedAt}!");
        }

        genre.DeletedAt = DateTime.UtcNow;
        genre.UpdatedAt = DateTime.UtcNow;
        await context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("Restore/{id:int}")]
    public async Task<ActionResult> RestoreGenreById(int id)
    {
        Genre genre = await context.Genres
            .FirstOrDefaultAsync(g => g.Id == id);

        if (genre is null)
        {
            return NotFound($"The genre with id {id} does not exist!");
        }

        if (genre.DeletedAt is null)
        {
            return NotFound($"The genre with id {id} is not deleted!");
        }

        genre.DeletedAt = null;
        genre.UpdatedAt = DateTime.UtcNow;
        await context.SaveChangesAsync();

        return Ok();
    }
}