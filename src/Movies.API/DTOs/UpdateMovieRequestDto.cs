namespace Movies.API.DTOs;

/// <summary>
/// JSON request body having details for movie to be updated.
/// </summary>
public class UpdateMovieRequestDto
{
    /// <summary>
    /// Unique ID of the movie generated during archive request.
    /// </summary>
    public int Id { get; set; }

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

    /// <summary>
    /// Latest timestamp of the changes made.
    /// </summary>
    public long Timestamp { get; set; }
}