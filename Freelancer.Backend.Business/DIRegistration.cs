using FluentValidation;
using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Business.Services;
using Freelancer.Backend.Business.Validators;
using Freelancer.Backend.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace Freelancer.Backend.Business
{
    public static class DIRegistration
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJobService, JobService>();
            services.AddScoped<IRateService, RateService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddValidatorsFromAssemblyContaining<RegisterValidator>();
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();
            return services;
        }
    }
}
