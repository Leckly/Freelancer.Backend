using Freelancer.Backend.Domain.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Freelancer.Backend.API.ExceptionHandling
{
    public sealed class CustomExceptionHandler
    {
        public async Task Invoke(HttpContext httpContext)
        {
            IExceptionHandlerFeature? exceptionDetails = httpContext.Features.Get<IExceptionHandlerFeature>();
            Exception? exception = exceptionDetails?.Error;

            if (exception != null && exception.GetType().IsSubclassOf(typeof(ApiBaseException)))
            {
                await HandleApiCustomException(httpContext, exception);
            }
        }

        private async Task HandleApiCustomException(HttpContext httpContext, Exception ex)
        {
            var typeName = ex.GetType().Name.ToLowerInvariant();

            switch(typeName)
            {
                case "entitynotfoundapiexception":
                    await HandleEntityNotFoundException(httpContext, ex);
                    break;
                case "validationapiexception":
                    await HandleValidationException(httpContext, ex);
                    break;
                case "userexistapiexception":
                    await HandleUserExistException(httpContext, ex); 
                    break;
                default:
                    await HandleGeneralException(httpContext, ex);
                    break;
            }
        }

        private async Task HandleGeneralException(HttpContext httpContext, Exception ex)
        {
            IProblemDetailsService problemDetailsService = httpContext.RequestServices.GetRequiredService<IProblemDetailsService>();
            IExceptionHandlerFeature? exceptionDetails = httpContext.Features.Get<IExceptionHandlerFeature>();

            httpContext.Response.StatusCode = 500;

            await problemDetailsService.WriteAsync(new ProblemDetailsContext
            {
                HttpContext = httpContext,
                AdditionalMetadata = exceptionDetails?.Endpoint?.Metadata,
                ProblemDetails = new ProblemDetails
                {
                    Status = 500,
                    Detail = ex.Message,
                    Title = "The unknown api custom error has occured."
                }
            });
        }

        private async Task HandleUserExistException(HttpContext httpContext, Exception ex)
        {
            IProblemDetailsService problemDetailsService = httpContext.RequestServices.GetRequiredService<IProblemDetailsService>();
            IExceptionHandlerFeature? exceptionDetails = httpContext.Features.Get<IExceptionHandlerFeature>();

            httpContext.Response.StatusCode = 409;

            await problemDetailsService.WriteAsync(new ProblemDetailsContext
            {
                HttpContext = httpContext,
                AdditionalMetadata = exceptionDetails?.Endpoint?.Metadata,
                ProblemDetails = new ProblemDetails
                {
                    Status = 409,
                    Detail = ex.Message,
                    Title = "User already exists."
                }
            });
        }

        private async Task HandleValidationException(HttpContext httpContext, Exception ex)
        {
            IProblemDetailsService problemDetailsService = httpContext.RequestServices.GetRequiredService<IProblemDetailsService>();
            IExceptionHandlerFeature? exceptionDetails = httpContext.Features.Get<IExceptionHandlerFeature>();

            httpContext.Response.StatusCode = 400;

            await problemDetailsService.WriteAsync(new ProblemDetailsContext
            {
                HttpContext = httpContext,
                AdditionalMetadata = exceptionDetails?.Endpoint?.Metadata,
                ProblemDetails = new ProblemDetails
                {
                    Status = 400,
                    Detail = ex.Message,
                    Title = "The provided entity is invalid."
                }
            });
        }

        private async Task HandleEntityNotFoundException(HttpContext httpContext, Exception ex)
        {
            IProblemDetailsService problemDetailsService = httpContext.RequestServices.GetRequiredService<IProblemDetailsService>();
            IExceptionHandlerFeature? exceptionDetails = httpContext.Features.Get<IExceptionHandlerFeature>();

            httpContext.Response.StatusCode = 404;

            await problemDetailsService.WriteAsync(new ProblemDetailsContext
            {
                HttpContext = httpContext,
                AdditionalMetadata = exceptionDetails?.Endpoint?.Metadata,
                ProblemDetails = new ProblemDetails
                {
                    Status = 500,
                    Detail = ex.Message,
                    Title = "The specified entity has not been found."
                }
            });
        }
    }
}
