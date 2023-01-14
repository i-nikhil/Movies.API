namespace Movies.API.Exceptions;

public class InvalidPageLimitException : Exception
{
    public InvalidPageLimitException(string errorMessage) : base(errorMessage)
    {

    }
}
