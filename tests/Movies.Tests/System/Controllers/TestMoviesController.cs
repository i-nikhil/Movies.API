using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Movies.API.Controllers;
using Movies.API.DTOs;
using Movies.API.Entities;
using Movies.API.Exceptions;
using Movies.API.Services.Interfaces;
using Xunit;

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
            sut.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext(),
            };
        }

        [Fact]
        public async Task GetAllMovie_ReturnsOkResult()
        {
            // Arrange
            int totalItems = 10;
            List<Movie> movies = new();
            mockMovieService.Setup(service => service.GetMovieCount())
                            .ReturnsAsync(totalItems);
            mockMovieService.Setup(service => service.GetAllMovie(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<SortColumn>(), It.IsAny<SortDirection>()))
                            .ReturnsAsync(movies);
            mockMapper.Setup(m => m.Map<IEnumerable<MovieResponseDto>>(It.IsAny<IEnumerable<Movie>>()))
                      .Returns(movies.Select(m => new MovieResponseDto()));

            // Act
            var result = await sut.GetAllMovie();

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetAllMovie_InvalidLimit_ReturnsBadRequest()
        {
            // Arrange
            int invalidLimit = 101;

            // Act & Assert
            await Assert.ThrowsAsync<InvalidPageLimitException>(() => sut.GetAllMovie(limit: invalidLimit));
        }

        [Fact]
        public async Task GetAllMovie_InvalidPageNumber_ReturnsBadRequest()
        {
            // Arrange
            int totalItems = 20;
            mockMovieService.Setup(service => service.GetMovieCount())
                            .ReturnsAsync(totalItems);

            // Act & Assert
            await Assert.ThrowsAsync<InvalidPageNumberException>(() => sut.GetAllMovie(page: totalItems + 1));
        }

        [Fact]
        public async Task GetMovieById_ReturnsOkResult()
        {
            // Arrange
            int movieId = 1;
            mockMovieService.Setup(service => service.GetMovieById(movieId))
                            .ReturnsAsync(new Movie());
            mockMapper.Setup(m => m.Map<MovieResponseDto>(It.IsAny<Movie>()))
                      .Returns(new MovieResponseDto());

            // Act
            ActionResult result = await sut.GetMovieById(movieId).ConfigureAwait(false);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            OkObjectResult okResult = result as OkObjectResult;
            Assert.NotNull(okResult?.Value);
            Assert.IsType<MovieResponseDto>(okResult.Value);
        }

        [Fact]
        public async Task SearchMovieByName_ReturnsOkResult()
        {
            // Arrange
            string searchTerm = "Action";
            mockMovieService.Setup(service => service.SearchMovieByName(searchTerm))
                            .ReturnsAsync(new List<Movie>());
            mockMapper.Setup(m => m.Map<IEnumerable<MovieResponseDto>>(It.IsAny<IEnumerable<Movie>>()))
                      .Returns(new List<MovieResponseDto>());

            // Act
            ActionResult result = await sut.SearchMovieByName(searchTerm).ConfigureAwait(false);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult?.Value);
            Assert.IsType<List<MovieResponseDto>>(okResult.Value);
        }

        [Fact]
        public async Task GroupMoviesByGenreId_ReturnsOkResult()
        {
            // Arrange
            int genreId = 1;
            mockMovieService.Setup(service => service.GroupMoviesByGenreId(genreId))
                            .ReturnsAsync(new List<string>());

            // Act
            var result = await sut.GroupMoviesByGenreId(genreId);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult?.Value);
            Assert.IsType<List<string>>(okResult.Value);
        }

        [Fact]
        public async Task PostMovie_ReturnsOkResult()
        {
            // Arrange
            var movieRequestDto = new CreateMovieRequestDto();
            var movie = new Movie();
            mockMovieService.Setup(service => service.PostMovie(movieRequestDto))
                            .ReturnsAsync(movie);
            mockMapper.Setup(m => m.Map<MovieResponseDto>(It.IsAny<Movie>()))
                      .Returns(new MovieResponseDto());

            // Act
            var result = await sut.PostMovie(movieRequestDto);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult?.Value);
            Assert.IsType<MovieResponseDto>(okResult.Value);
        }

        [Fact]
        public async Task UpdateMovie_ReturnsOkResult()
        {
            // Arrange
            var movieRequestDto = new UpdateMovieRequestDto();
            var updatedMovie = new Movie();
            mockMovieService.Setup(service => service.UpdateMovie(movieRequestDto))
                            .ReturnsAsync(updatedMovie);
            mockMapper.Setup(m => m.Map<MovieResponseDto>(It.IsAny<Movie>()))
                      .Returns(new MovieResponseDto());

            // Act
            var result = await sut.UpdateMovie(movieRequestDto);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult?.Value);
            Assert.IsType<MovieResponseDto>(okResult.Value);
        }

        [Fact]
        public async Task DeleteMovieById_ReturnsOkResult()
        {
            // Arrange
            int movieId = 1;

            // Act
            var result = await sut.DeleteMovieById(movieId);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult?.Value);
            Assert.IsType<string>(okResult.Value);
        }

        [Fact]
        public async Task RestoreMovieById_ReturnsOkResult()
        {
            // Arrange
            int movieId = 1;

            // Act
            var result = await sut.RestoreMovieById(movieId);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult?.Value);
            Assert.IsType<string>(okResult.Value);
        }
    }
}