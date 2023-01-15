using Movies.API.DTOs;
using Movies.API.Entities;

namespace Movies.API.Services.Interfaces;

public interface IMoviesService
{
    Task<List<Movie>> GetAllMovie(int page, int limit, SortColumn sortCol, SortDirection sortDir);
    Task<int> GetMovieCount();
    Task<Movie> GetMovieById(int id);
    Task<List<Movie>> SearchMovieByName(string term);
    Task<List<string>> GroupMoviesByGenreId(int id);
    Task<Movie> PostMovie(CreateMovieRequestDto movieRequestDto);
    Task<Movie> UpdateMovie(UpdateMovieRequestDto movieRequestDto);
    Task<Movie> DeleteMovieById(int id);
    Task<Movie> RestoreMovieById(int id);
}