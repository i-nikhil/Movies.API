namespace Movies.API.Exceptions;

public class TimestampMismatchException : Exception
{
    public TimestampMismatchException(string errorMessage) : base(errorMessage)
    {
    }
}