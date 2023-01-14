namespace Movies.API.Exceptions;

public class MovieNotFoundException : Exception
{
    public MovieNotFoundException(string errorMessage) : base(errorMessage)
    {

    }
}