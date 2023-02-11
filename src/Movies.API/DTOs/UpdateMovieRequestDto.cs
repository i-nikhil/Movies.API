namespace Movies.API.DTOs;

public class UpdateMovieRequestDto
{
    public int Id { get; set; }

    public string Title { get; set; }

    public int ReleaseYear { get; set; }

    public int RuntimeMinutes { get; set; }

    public HashSet<int> GenreIds { get; set; }

    public long Timestamp { get; set; }
}