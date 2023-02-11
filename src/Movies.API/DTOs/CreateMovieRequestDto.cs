namespace Movies.API.DTOs;

public class CreateMovieRequestDto
{
    public string Title { get; set; }

    public int ReleaseYear { get; set; }

    public int RuntimeMinutes { get; set; }

    public HashSet<int> GenreIds { get; set; }
}