namespace Movies.API.DTOs;

public class MovieResponseDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int ReleaseYear { get; set; }
    public int RuntimeMinutes { get; set; }
    public IEnumerable<GenreResponseDto> Genres { get; set; }
}
