
namespace Freelancer.Backend.Domain.Exceptions;

public class UserNotFoundApiException : ApiBaseException
{
    public UserNotFoundApiException()
    {
    }

    public UserNotFoundApiException(string? message) : base(message)
    {
    }

    public UserNotFoundApiException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
