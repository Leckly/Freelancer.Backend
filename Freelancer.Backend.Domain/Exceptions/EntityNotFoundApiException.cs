
namespace Freelancer.Backend.Domain.Exceptions
{
    public class EntityNotFoundApiException : ApiBaseException
    {
        public EntityNotFoundApiException()
        {
        }

        public EntityNotFoundApiException(string? message) : base(message)
        {
        }

        public EntityNotFoundApiException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
