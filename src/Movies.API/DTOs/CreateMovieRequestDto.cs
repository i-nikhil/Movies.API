using System.ComponentModel.DataAnnotations;

namespace Movies.API.DTOs;

public class CreateMovieRequestDto
{
    [Required(ErrorMessage = "Title is required")]
    public string Title { get; set; }

    [Required(ErrorMessage = "Release Year is required")]
    [Range(1000, 9999, ErrorMessage = "Invalid Release Year")]
    public int ReleaseYear { get; set; }

    [Required(ErrorMessage = "Runtime Minutes is required")]
    [Range(30, 240, ErrorMessage = "Runtime should be between 30 minutes to 4 hours")]
    public int RuntimeMinutes { get; set; }

    [Required(ErrorMessage = "Genre Id is required")]
    [MinLength(1, ErrorMessage = "Minimum one Genre Id is required")]
    public HashSet<int> GenreIds { get; set; }
}