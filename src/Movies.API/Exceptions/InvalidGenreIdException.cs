namespace Movies.API.Exceptions;

public class InvalidGenreIdException : Exception
{
    public InvalidGenreIdException(string errorMessage) : base(errorMessage)
    {
    }
}