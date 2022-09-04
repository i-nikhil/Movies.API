namespace Movies.Domain.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public GenreName Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public ICollection<MovieGenreMapping> Movies { get; set; }
    }

    public enum GenreName
    {
        Comedy = 0,
        Drama,
        Thriller,
        Horror,
        Retro
    }
}
