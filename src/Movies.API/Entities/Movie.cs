namespace Movies.API.Entities;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public int RuntimeMinutes { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public ICollection<MovieGenreMapping> Genres { get; set; }
}

public enum SortColumn
{
    Title,
    ReleaseYear,
    RuntimeMinutes
}

public enum SortDirection
{
    Asc,
    Desc
}