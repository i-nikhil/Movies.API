using Moq;
using Movies.API.Controllers;
using Movies.API.Services.Interfaces;
using Xunit;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using Movies.API.Entities;
using Microsoft.OpenApi.Extensions;

namespace Movies.UnitTest.System.Controllers
{
    public class TestGenresController
    {
        private readonly Mock<IGenresService> mockGenresService;
        private readonly Mock<IMapper> mockMapper;
        private readonly GenresController sut;

        public TestGenresController()
        {
            mockGenresService = new Mock<IGenresService>();
            mockMapper = new Mock<IMapper>();
            sut = new GenresController(mockGenresService.Object, mockMapper.Object);
        }

        [Fact]
        public async Task GetAllGenre_ReturnsOK()
        {
            //Arrange
            mockGenresService.Setup(mgs => mgs.GetAllGenre()).ReturnsAsync(new List<Genre>());

            //Act
            IActionResult result = await sut.GetAllGenre().ConfigureAwait(false);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetGenreById_ReturnsOK()
        {
            //Arrange
            mockGenresService.Setup(mgs => mgs.GetGenreById(1)).ReturnsAsync(new Genre());

            //Act
            IActionResult result = await sut.GetGenreById(1).ConfigureAwait(false);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task SearchGenreByName_ReturnsOK()
        {
            //Arrange
            mockGenresService.Setup(mgs => mgs.SearchGenreByName(GenreName.Comedy.GetDisplayName())).ReturnsAsync(new List<Genre>());

            //Act
            IActionResult result = await sut.SearchGenreByName(GenreName.Comedy.GetDisplayName()).ConfigureAwait(false);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<OkObjectResult>();
        }

        [Fact]
        public async Task GetAllGenreTimestamps_ReturnsOK()
        {
            //Arrange
            mockGenresService.Setup(mgs => mgs.GetAllGenreTimestamps()).ReturnsAsync(new List<Genre>());

            //Act
            IActionResult result = await sut.GetAllGenreTimestamps().ConfigureAwait(false);

            //Assert
            result.Should().NotBeNull();
            result.Should().BeOfType<OkObjectResult>();
        }
    }
}