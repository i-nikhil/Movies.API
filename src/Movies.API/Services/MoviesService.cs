using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Exceptions;
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

    public async Task<int> GetMovieCount()
    {
        return await movieRepository.GetMovieCount();
    }

    public async Task<Movie> GetMovieById(int id)
    {
        if (id <= 0)
        {
            throw new InvalidMovieIdException("Invalid Movie Id");
        }

        Movie movie = await movieRepository.GetMovieById(id);

        if (movie is null)
        {
            throw new MovieNotFoundException($"The movie with id {id} does not exist!");
        }

        return movie;
    }

    public async Task<List<Movie>> SearchMovieByName(string term)
    {
        if (string.IsNullOrEmpty(term) || string.IsNullOrWhiteSpace(term))
        {
            throw new InvalidSearchTermException("Search term cannot be empty");
        }

        List<Movie> movies = await movieRepository.SearchMovieByName(term.Trim());

        if (movies.Count == 0)
        {
            throw new MovieNotFoundException($"No matching movie found!");
        }

        return movies;
    }

    public async Task<List<string>> GroupMoviesByGenreId(int id)
    {
        if (id <= 0)
        {
            throw new InvalidGenreIdException("Invalid Genre Id");
        }

        List<string> movies = await movieRepository.GroupMoviesByGenreId(id);

        if (movies.Count == 0)
        {
            throw new MovieNotFoundException($"No movie found!");
        }

        return movies;
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
        if (id <= 0)
        {
            throw new InvalidMovieIdException("Invalid Movie Id");
        }

        return await movieRepository.DeleteMovieById(id);
    }

    public async Task<Movie> RestoreMovieById(int id)
    {
        if (id <= 0)
        {
            throw new InvalidMovieIdException("Invalid Movie Id");
        }

        return await movieRepository.RestoreMovieById(id);
    }
}