namespace Movies.Domain.Entities
{
    public class MovieGenreMapping
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }    
    }
}
