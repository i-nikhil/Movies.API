using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movies.Domain.Entities;
using Movies.Infrastructure;

namespace Movies.API.Controllers
{
    [ApiController]
    [Route("Genres")]
    public class GenresController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public GenresController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Genre>> GetAllGenre()
        {
            return await context.Genres.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetGenreById(int id)
        {
            Genre genres = await context.Genres.FirstOrDefaultAsync(g => g.Id == id);

            if (genres is null)
            {
                return NotFound($"The genre with id {id} does not exist!");
            }
            return Ok(genres);
        }
    }
}