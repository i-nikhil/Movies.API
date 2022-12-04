using Movies.API.Entities;
using Movies.API.Repositories.Interfaces;
using Movies.API.Services.Interfaces;

namespace Movies.API.Services;

public class GenresService : IGenresService
{
    private readonly IGenresRepository genreRepository;
    public GenresService(IGenresRepository genreRepository)
    {
        this.genreRepository = genreRepository;
    }

    public async Task<List<Genre>> GetAllGenre()
    {
        return await genreRepository.GetAllGenre();
    }
    public async Task<Genre> GetGenreById(int id)
    {
        return await genreRepository.GetGenreById(id);
    }

    public async Task<List<Genre>> SearchGenreByName(string term)
    {
        List<Genre> genres = await genreRepository.GetAllGenre();

        List<Genre> matchingGenres = new();

        matchingGenres.AddRange(from genre in genres
                                where genre.Name.ToString().Contains(term, StringComparison.CurrentCultureIgnoreCase)
                                select genre);

        return matchingGenres;
    }

    public async Task<List<Genre>> GetAllGenreTimestamps()
    {
        return await genreRepository.GetAllGenreTimestamps();
    }

    public async Task<Genre> DeleteGenreById(int id)
    {
        return await genreRepository.DeleteGenreById(id);
    }

    public async Task<Genre> RestoreGenreById(int id)
    {
        return await genreRepository.RestoreGenreById(id);
    }
}