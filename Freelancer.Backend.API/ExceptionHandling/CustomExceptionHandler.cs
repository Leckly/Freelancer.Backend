using Freelancer.Backend.Domain.Exceptions;
using Newtonsoft.Json;
using Serilog;

namespace Freelancer.Backend.API.ExceptionHandling
{
    public sealed class CustomExceptionHandler
    {
        private readonly RequestDelegate _next;

        public CustomExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (EntityNotFoundApiException ex)
            {
                await HandleEntityNotFoundException(httpContext, ex);
                Log.Error(ex, "Entity not found exception.");
            }
            catch (ValidationApiException ex)
            {
                await HandleValidationException(httpContext, ex);
                Log.Error(ex, "Validation exception.");
            }
            catch (UserExistApiException ex)
            {
                await HandleRecordExistException(httpContext, ex);
                Log.Error(ex, "User exist exception.");
            }
            catch (UserNotFoundApiException ex)
            {
                await HandleUserNotFoundException(httpContext, ex);
                Log.Error(ex, "User not found");
            }
            catch (ApiBaseException ex)
            {
                await HandleGeneralException(httpContext, ex);
                Log.Error(ex, "General exception.");
            }
            catch (Exception ex)
            {
                await HandleGeneralException(httpContext, ex);
                Log.Error(ex, "Unhandled exception.");
            }
        }

        private async Task HandleUserNotFoundException(HttpContext context, UserNotFoundApiException ex)
        {
            await HandleException(context, 404, "User not exists");
        }

        private static async Task HandleEntityNotFoundException(HttpContext context, Exception ex)
        {
            await HandleException(context, 404, "The specified entity has not been found.");
        }

        private static async Task HandleValidationException(HttpContext context, Exception ex)
        {
            await HandleException(context, 400, "The provided entity is invalid.");
        }

        private static async Task HandleRecordExistException(HttpContext context, Exception ex)
        {
            await HandleException(context, 409, "User already exist.");
        }

        private static async Task HandleGeneralException(HttpContext context, Exception ex)
        {
            await HandleException(context, 500, "An unknown error has occured.");
        }

        private static async Task HandleException(HttpContext context, int statusCode, string message)
        {
            context.Response.Clear();
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "application/json";

            var exceptionViewModel = new ExceptionViewModel()
            {
                StatusCode = statusCode,
                Message = message
            };

            var serializedException = JsonConvert.SerializeObject(exceptionViewModel);

            await context.Response.WriteAsync(serializedException);
        }
    }
}
