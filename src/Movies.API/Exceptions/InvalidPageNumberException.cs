namespace Movies.API.Exceptions;
public class InvalidPageNumberException : Exception
{
    public InvalidPageNumberException(string errorMessage) : base(errorMessage)
    {

    }
}