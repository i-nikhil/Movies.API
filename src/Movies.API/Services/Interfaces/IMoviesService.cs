using Movies.API.DTOs;
using Movies.API.Entities;

namespace Movies.API.Services.Interfaces;

public interface IMoviesService
{
    Task<List<Movie>> GetAllMovie();
    Task<Movie> GetMovieById(int id);
    Task<List<Movie>> SearchMovieByName(string term);
    Task<List<string>> GroupMoviesByGenreId(int id);
    Task<Movie> PostMovie(MovieRequestDto movieRequestDto);
    Task<Movie> DeleteMovieById(int id);
    Task<Movie> RestoreMovieById(int id);
}