using FluentValidation;
using Movies.API.DTOs;

namespace Movies.API.Validators
{
    public class UpdateMovieRequestDtoValidator : AbstractValidator<UpdateMovieRequestDto>
    {
        public UpdateMovieRequestDtoValidator()
        {
            RuleFor(u => u.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is Required")
                .InclusiveBetween(0, int.MaxValue)
                .WithMessage("Invalid {PropertyName}");

            RuleFor(u => u.Title)
                .NotNull()
                .WithMessage("{PropertyName} is Required")
                .MinimumLength(2)
                .WithMessage("{PropertyName} should be minimum 2 in length")
                .MaximumLength(200)
                .WithMessage("{PropertyName} should be maximum 200 in length")
                .Must(Title => !string.IsNullOrEmpty(Title) && !string.IsNullOrWhiteSpace(Title))
                .WithMessage("{PropertyName} cannot be null or empty");

            RuleFor(u => u.ReleaseYear)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .InclusiveBetween(DateTime.MinValue.Year, DateTime.UtcNow.Year)
                .WithMessage("Invalid {PropertyName}");

            RuleFor(u => u.RuntimeMinutes)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .GreaterThan(30)
                .WithMessage("{PropertyName} should be grater than 30 minutes")
                .LessThan(240)
                .WithMessage("{PropertyName} should be less than 4 hours");

            RuleFor(u => u.GenreIds)
                .NotNull()
                .WithMessage("{PropertyName} is Required")
                .NotEmpty()
                .WithMessage("Aleast one genre is required")
                .ForEach(genreId => genreId.GreaterThanOrEqualTo(0))
                .WithMessage("{PropertyName} should be positive");

            RuleFor(u => u.Timestamp)
                .NotNull()
                .NotEmpty()
                .WithMessage("{PropertyName} is Required")
                .InclusiveBetween(0, long.MaxValue)
                .WithMessage("Invalid {PropertyName}");
        }
    }
}
