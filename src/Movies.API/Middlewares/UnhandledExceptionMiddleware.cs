using Microsoft.AspNetCore.Mvc;
using Movies.API.Exceptions;
using System.Text.Json;

namespace Movies.API.Middlewares;

public class UnhandledExceptionMiddleware
{
    private readonly RequestDelegate _next;
    public UnhandledExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            ProblemDetails details;

            switch (ex)
            {
                case MovieNotFoundException:
                case GenreNotFoundException:
                    context.Response.StatusCode = 404;
                    details = new ProblemDetails
                    {
                        Status = 404,
                        Detail = ex.Message
                    };
                    break;
                case DuplicateMovieException:
                case InvalidPageNumberException:
                case InvalidPageLimitException:
                case InvalidMovieIdException:
                case InvalidGenreIdException:
                case InvalidSearchTermException:
                case TimestampMismatchException:
                    context.Response.StatusCode = 400;
                    details = new ProblemDetails
                    {
                        Status = 400,
                        Detail = ex.Message
                    };
                    break;
                default:
                    context.Response.StatusCode = 500;
                    details = new ProblemDetails
                    {
                        Type = ex.GetType().ToString(),
                        Status = 500,
                        Detail = ex.Message
                    };
                    break;
            }

            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonSerializer.Serialize(details));
        }
    }
}