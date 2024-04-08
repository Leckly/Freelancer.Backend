
namespace Freelancer.Backend.Domain.Exceptions
{
    public class ValidationApiException : ApiBaseException
    {
        public ValidationApiException()
        {
        }

        public ValidationApiException(string? message) : base(message)
        {
        }

        public ValidationApiException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
