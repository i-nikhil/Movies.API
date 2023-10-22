using Movies.API.Entities;

namespace Movies.API.Repositories.Interfaces;

public interface IGenresRepository
{
    Task<List<Genre>> GetAllGenre();
    Task<Genre> GetGenreById(int id);
    Task<List<Genre>> SearchGenreByName(string term);
    Task<List<Genre>> GetAllGenreTimestamps();
}