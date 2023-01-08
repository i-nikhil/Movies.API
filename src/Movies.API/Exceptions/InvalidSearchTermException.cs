namespace Movies.API.Exceptions;

public class InvalidSearchTermException : Exception
{
    public InvalidSearchTermException(string errorMessage) : base(errorMessage)
    {
    }
}