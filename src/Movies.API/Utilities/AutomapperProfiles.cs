using AutoMapper;
using Movies.API.DTOs;
using Movies.API.Entities;

namespace Movies.API.Utilities;

public class AutomapperProfiles : Profile
{
    public AutomapperProfiles()
    {
        CreateMap<Genre, GenreResponseDto>();

        CreateMap<Movie, MovieResponseDto>()
            .ForMember(
            dest => dest.Genres,
            src => src.MapFrom(y => y.Genres.Select(z => new GenreResponseDto
            {
                Id = z.GenreId,
                Name = z.Genre.Name.ToString()
            }))
            );
    }
}