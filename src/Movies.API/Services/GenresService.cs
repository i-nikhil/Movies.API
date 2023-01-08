using Movies.API.Entities;
using Movies.API.Exceptions;
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
        if (id <= 0)
        {
            throw new InvalidGenreIdException("Invalid Genre Id");
        }

        Genre genre = await genreRepository.GetGenreById(id);

        if (genre is null)
        {
            throw new GenreNotFoundException($"Genre with id {id} does not exist!");
        }

        return genre;
    }

    public async Task<List<Genre>> SearchGenreByName(string term)
    {
        if (string.IsNullOrEmpty(term) || string.IsNullOrWhiteSpace(term))
        {
            throw new InvalidSearchTermException("Search term cannot be empty");
        }

        List<Genre> genres = await genreRepository.GetAllGenre();

        List<Genre> matchingGenres = new();

        matchingGenres.AddRange(from genre in genres
                                where genre.Name.ToString().Contains(term.Trim(), StringComparison.CurrentCultureIgnoreCase)
                                select genre);

        if (matchingGenres.Count == 0)
        {
            throw new GenreNotFoundException("No matching genre found!");
        }

        return matchingGenres;
    }

    public async Task<List<Genre>> GetAllGenreTimestamps()
    {
        return await genreRepository.GetAllGenreTimestamps();
    }

    public async Task<Genre> DeleteGenreById(int id)
    {
        if (id <= 0)
        {
            throw new InvalidGenreIdException("Invalid Genre Id");
        }

        return await genreRepository.DeleteGenreById(id);
    }

    public async Task<Genre> RestoreGenreById(int id)
    {
        if (id <= 0)
        {
            throw new InvalidGenreIdException("Invalid Genre Id");
        }

        return await genreRepository.RestoreGenreById(id);
    }
}