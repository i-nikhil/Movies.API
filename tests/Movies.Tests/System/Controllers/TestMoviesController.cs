using AutoMapper;
using Moq;
using Movies.API.Controllers;
using Movies.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.UnitTest.System.Controllers
{
    public class TestMoviesController
    {
        private readonly Mock<IMoviesService> mockMovieService;
        private readonly Mock<IMapper> mockMapper;
        private readonly MoviesController sut;

        public TestMoviesController()
        {
            mockMovieService = new Mock<IMoviesService>();
            mockMapper = new Mock<IMapper>();
            sut = new MoviesController(mockMovieService.Object, mockMapper.Object);
        }
    }
}
