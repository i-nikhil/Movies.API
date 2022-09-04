using AutoMapper;
using Movies.Domain.DTOs;
using Movies.Domain.Entities;

namespace Movies.API.Utilities
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Genre, GenreResponseDto>();
        }
    }
}