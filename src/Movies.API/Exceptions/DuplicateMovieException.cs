namespace Movies.API.Exceptions;

public class DuplicateMovieException : Exception
{
    public DuplicateMovieException(string errorMessage) : base(errorMessage)
    {

    }
}
