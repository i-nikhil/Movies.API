using Movies.API.DTOs;
using Movies.API.Entities;

namespace Movies.API.Repositories.Interfaces;

public interface IMoviesRepository
{
    Task<List<Movie>> GetAllMovie(int page, int limit, SortColumn sortCol, SortDirection sortDir);
    Task<Movie> GetMovieById(int id);
    Task<List<Movie>> SearchMovieByName(string term);
    Task<List<string>> GroupMoviesByGenreId(int id);
    Task<Movie> PostMovie(CreateMovieRequestDto movieRequestDto);
    Task<Movie> UpdateMovie(UpdateMovieRequestDto movieRequestDto);
    Task<Movie> DeleteMovieById(int id);
    Task<Movie> RestoreMovieById(int id);
}