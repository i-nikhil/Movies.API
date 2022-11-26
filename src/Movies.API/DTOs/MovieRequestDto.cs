namespace Movies.API.DTOs;

public class MovieRequestDto
{
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public int RuntimeMinutes { get; set; }
    public List<int> GenreIds { get; set; }
}