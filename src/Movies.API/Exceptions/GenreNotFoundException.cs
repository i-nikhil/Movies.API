namespace Movies.API.Exceptions;

public class GenreNotFoundException : Exception
{
	public GenreNotFoundException(string errorMessage) : base(errorMessage)
	{
	}
}