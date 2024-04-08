namespace Freelancer.Backend.Domain.Exceptions
{
    public class UserExistApiException : ApiBaseException
    {
        public UserExistApiException()
        {
        }

        public UserExistApiException(string? message) : base(message)
        {
        }

        public UserExistApiException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
