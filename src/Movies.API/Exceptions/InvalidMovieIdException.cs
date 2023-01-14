namespace Movies.API.Exceptions;

public class InvalidMovieIdException : Exception
{
    public InvalidMovieIdException(string errorMessage) : base(errorMessage)
    {

    }
}
