using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Movies.API;
using Movies.API.Middlewares;
using Movies.API.Repositories;
using Movies.API.Repositories.Interfaces;
using Movies.API.Services;
using Movies.API.Services.Interfaces;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddValidatorsFromAssemblyContaining<Program>(ServiceLifetime.Transient);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => 
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "MovieArchives.API",
        Version = "V1-Beta",
        Description = "Welcome to MovieArchives.API, a handcrafted API management portal built on the robust foundation of .NET 6 powered by the latest Entity Framework Core techniques. Our features include 'Auto Mapper' for seamless data mapping, 'Fluent Validation' for rigorous parameter validation, and cutting-edge 'Xunit' for comprehensive code coverage. Our database is hosted on Azure SQL Cloud for reliability, and the codebase is efficiently deployed through Azure App Service. We've also seamlessly integrated with a CI/CD pipeline to support continuous delivery. Explore our detailed Swagger UI for effortless testing and integration. To explore the source code, please click below on 'Terms of Service'.",
        TermsOfService = new Uri("https://github.com/i-nikhil/Movies.API"),
        Contact = new OpenApiContact
        {
            Name = "me for feedback or suggestions.",
            Email = "nikhilprakash510@gmail.com",
        }
    });

    string xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    string xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFilename);
    options.IncludeXmlComments(xmlPath);
});
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddFluentValidation(x => x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer("name=AzureConnection");
});
builder.Services.AddScoped<IGenresService, GenresService>();
builder.Services.AddScoped<IGenresRepository, GenresRepository>();
builder.Services.AddScoped<IMoviesService, MoviesService>();
builder.Services.AddScoped<IMoviesRepository, MoviesRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();
app.UseMiddleware<UnhandledExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();