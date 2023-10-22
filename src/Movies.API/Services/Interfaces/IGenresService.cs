using Microsoft.AspNetCore.Mvc;
using Movies.API.Entities;

namespace Movies.API.Services.Interfaces;

public interface IGenresService
{
    Task<List<Genre>> GetAllGenre();
    Task<Genre> GetGenreById(int id);
    Task<List<Genre>> SearchGenreByName(string term);
    Task<List<Genre>> GetAllGenreTimestamps();
}