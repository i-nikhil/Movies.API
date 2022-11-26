using FluentValidation;
using Movies.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.Validators
{
    public class MovieRequestDtoValidator : AbstractValidator<MovieRequestDto>
    {
        public MovieRequestDtoValidator()
        {
            RuleFor(c => c.Title)
                .NotNull()
                .WithMessage("Title is Required");

            RuleFor(c => c.Title)
                .MinimumLength(2)
                .WithMessage("Title should be minimum 2 in length");

            RuleFor(c => c.Title)
                .MaximumLength(200)
                .WithMessage("Title should be maximum 200 in length");

            RuleFor(c => c.RuntimeMinutes)
                .NotNull()
                .WithMessage("Runtime is required");

            RuleFor(c => c.RuntimeMinutes)
                .GreaterThan(30)
                .WithMessage("Runtime should be grater than 30 minutes");

            RuleFor(c => c.RuntimeMinutes)
                .LessThan(30)
                .WithMessage("Runtime should be less than 5 hours");

            RuleFor(c => c.ReleaseYear)
                .NotNull()
                .WithMessage("Release year is required");

            RuleFor(c => c.ReleaseYear)
                .InclusiveBetween(DateTime.MinValue.Year, DateTime.Now.Year)
                .WithMessage("Invalid release year");

            RuleFor(c => c.GenreIds)
                .NotNull()
                .NotEmpty()
                .WithMessage("Aleast one genre is required");

            RuleFor(c => c.GenreIds)
                .ForEach(c=>c.GreaterThanOrEqualTo(0))
                .WithMessage("Genre id should be positive");
        }
    }
}
