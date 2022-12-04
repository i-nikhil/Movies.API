using Movies.API.DTOs;
using Movies.API.Entities;

namespace Movies.API.Repositories.Interfaces;

public interface IMoviesRepository
{
    Task<List<Movie>> GetAllMovie();
    Task<Movie> GetMovieById(int id);
    Task PostMovie(MovieRequestDto movieRequestDto);
    Task<Movie> DeleteMovieById(int id);
    Task<Movie> RestoreMovieById(int id);
}