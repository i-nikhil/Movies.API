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

    public async Task<List<Movie>> GetAllMovie()
    {
        return await movieRepository.GetAllMovie();
    }
    
    public async Task<Movie> GetMovieById(int id)
    {
        return await movieRepository.GetMovieById(id);
    }
    
    public async Task<List<Movie>> SearchMovieByName(string term)
    {
        List<Movie> movies = await movieRepository.GetAllMovie();

        List<Movie> matchingMovies = new();

        matchingMovies.AddRange(from movie in movies
                                where movie.Title.Contains(term, StringComparison.CurrentCultureIgnoreCase)
                                select movie);

        return matchingMovies;
    }

    public async Task<List<string>> GroupMoviesByGenreId(int id)
    {
        return await movieRepository.GroupMoviesByGenreId(id);
    }

    public async Task<Movie> PostMovie(MovieRequestDto movieRequestDto)
    {
        return await movieRepository.PostMovie(movieRequestDto);
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