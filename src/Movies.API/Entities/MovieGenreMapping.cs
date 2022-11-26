namespace Movies.API.Entities;

public class MovieGenreMapping
{
    public int Id { get; set; }
    public Movie Movie { get; set; }
    public int MovieId { get; set; }
    public Genre Genre { get; set; }
    public int GenreId { get; set; }
}
