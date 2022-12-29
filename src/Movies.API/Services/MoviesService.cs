using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Repositories.Interfaces;
using Movies.API.Services.Interfaces;

namespace Movies.API.Services;

public class MoviesService : IMoviesService
{
    private readonly IMoviesRepository movieRepository;
    public MoviesService(IMoviesRepository movieRepository)
    {
        this.movieRepository = movieRepository;
    }

    public async Task<List<Movie>> GetAllMovie(int page, int limit, SortColumn sortCol, SortDirection sortDir)
    {
        return await movieRepository.GetAllMovie(page, limit, sortCol, sortDir);
    }
    
    public async Task<Movie> GetMovieById(int id)
    {
        return await movieRepository.GetMovieById(id);
    }
    
    public async Task<List<Movie>> SearchMovieByName(string term)
    {
        return await movieRepository.SearchMovieByName(term);
    }

    public async Task<List<string>> GroupMoviesByGenreId(int id)
    {
        return await movieRepository.GroupMoviesByGenreId(id);
    }

    public async Task<Movie> PostMovie(CreateMovieRequestDto movieRequestDto)
    {
        return await movieRepository.PostMovie(movieRequestDto);
    }

    public async Task<Movie> UpdateMovie(UpdateMovieRequestDto movieRequestDto)
    {
        return await movieRepository.UpdateMovie(movieRequestDto);
    }

    public async Task<Movie> DeleteMovieById(int id)
    {
        return await movieRepository.DeleteMovieById(id);
    }

    public async Task<Movie> RestoreMovieById(int id)
    {
        return await movieRepository.RestoreMovieById(id);
    }
}