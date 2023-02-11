using FluentValidation;
using Movies.API.DTOs;

namespace Movies.API.Validators
{
    public class CreateMovieRequestDtoValidator : AbstractValidator<CreateMovieRequestDto>
    {
        public CreateMovieRequestDtoValidator()
        {
            RuleFor(c => c.Title)
                .NotNull()
                .WithMessage("{PropertyName} is Required")
                .MinimumLength(2)
                .WithMessage("{PropertyName} should be minimum 2 in length")
                .MaximumLength(200)
                .WithMessage("{PropertyName} should be maximum 200 in length")
                .Must(Title => !string.IsNullOrEmpty(Title) && !string.IsNullOrWhiteSpace(Title))
                .WithMessage("{PropertyName} cannot be null or empty");

            RuleFor(c => c.ReleaseYear)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .InclusiveBetween(DateTime.MinValue.Year, DateTime.UtcNow.Year)
                .WithMessage("Invalid {PropertyName}");

            RuleFor(c => c.RuntimeMinutes)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .GreaterThan(30)
                .WithMessage("{PropertyName} should be grater than 30 minutes")
                .LessThan(240)
                .WithMessage("{PropertyName} should be less than 4 hours");

            RuleFor(c => c.GenreIds)
                .NotNull()
                .WithMessage("{PropertyName} is Required")
                .NotEmpty()
                .WithMessage("Aleast one genre is required")
                .ForEach(genreId => genreId.GreaterThanOrEqualTo(0))
                .WithMessage("{PropertyName} should be positive");
        }
    }
}