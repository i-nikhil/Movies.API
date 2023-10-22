namespace Movies.API.Entities;

/// <summary>
/// Movie entity model.
/// </summary>
public class Movie
{
    /// <summary>
    /// Unique ID of the movie.
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
    /// Movie archived timestamp.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Movie updated timestamp.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Movie deleted timestamp.
    /// </summary>
    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// Collection of genres mapped with this movie.
    /// </summary>
    public ICollection<MovieGenreMapping> Genres { get; set; }
}

/// <summary>
/// Field based on which movies needs to be sorted.
/// </summary>
public enum SortColumn
{
    /// <summary>
    /// Name of the movie.
    /// </summary>
    Title,

    /// <summary>
    /// Year of release of the movie.
    /// </summary>
    ReleaseYear,

    /// <summary>
    /// Duration of the movie in minutes.
    /// </summary>
    RuntimeMinutes
}

/// <summary>
/// Sorting order of the field selected.
/// </summary>
public enum SortDirection
{
    /// <summary>
    /// Ascending order.
    /// </summary>
    Asc,

    /// <summary>
    /// Descending order.
    /// </summary>
    Desc
}