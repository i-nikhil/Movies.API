using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Domain.DTOs;
using Movies.Domain.Entities;
using Movies.Infrastructure;

namespace Movies.API.Controllers
{
    [ApiController]
    [Route("Movies")]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        public MoviesController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<MovieResponseDto>> GetAllMovie()
        {
            return await context.Movies
                 .Include(m => m.Genres)
                 .OrderByDescending(m => EF.Property<DateTime>(m, "CreatedAt"))
                 .ProjectTo<MovieResponseDto>(mapper.ConfigurationProvider)
                 .ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetGenreById(int id)
        {
            MovieResponseDto movie = await context.Movies
                .Include(m => m.Genres)
                .ProjectTo<MovieResponseDto>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(g => g.Id == id);

            if (movie is null)
            {
                return NotFound($"The movie with id {id} does not exist!");
            }

            return Ok(movie);
        }
    }
}
