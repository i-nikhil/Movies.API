using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Domain.DTOs;
using Movies.Infrastructure;

namespace Movies.API.Controllers
{
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
        public async Task<IEnumerable<GenreResponseDto>> GetAllGenre()
        {
            return await context.Genres
                .ProjectTo<GenreResponseDto>(mapper.ConfigurationProvider)
                .ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetGenreById(int id)
        {
            GenreResponseDto genre = await context.Genres
                .ProjectTo<GenreResponseDto>(mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(g => g.Id == id);

            if (genre is null)
            {
                return NotFound($"The genre with id {id} does not exist!");
            }

            return Ok(genre);
        }
    }
}