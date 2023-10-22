namespace Movies.API.Entities;

/// <summary>
/// Genre entity model.
/// </summary>
public class Genre
{
    /// <summary>
    /// Unique ID of the genre.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Name of the genre.
    /// </summary>
    public GenreName Name { get; set; }

    /// <summary>
    /// Genre created timestamp.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Genre updated timestamp.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Genre deleted timestamp.
    /// </summary>
    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// Collection of movies categorized under this genre.
    /// </summary>
    public ICollection<MovieGenreMapping> Movies { get; set; }
}

/// <summary>
/// Genre names.
/// </summary>
public enum GenreName
{
    Comedy = 0,
    Drama,
    Thriller,
    Horror,
    Action,
    Retro,
    Crime,
    Biopic,
    Fiction,
    Romance
}
