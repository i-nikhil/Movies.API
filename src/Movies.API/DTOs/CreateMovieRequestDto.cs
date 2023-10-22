namespace Movies.API.DTOs;

/// <summary>
/// JSON request body having details for movie to be archived.
/// </summary>
public class CreateMovieRequestDto
{
    /// <summary>
    /// Name of the movie.
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// Year of release of the movie.
    /// </summary>
    public int ReleaseYear { get; set; }

    /// <summary>
    /// Duration of the movie in minutes.
    /// </summary>
    public int RuntimeMinutes { get; set; }

    /// <summary>
    /// List of genre IDs to be mapped with this movie.
    /// </summary>
    public HashSet<int> GenreIds { get; set; }
}