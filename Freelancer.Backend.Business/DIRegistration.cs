using Freelancer.Backend.Business.Interfaces;
using Freelancer.Backend.Business.Services;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace Freelancer.Backend.Business
{
    public static class DIRegistration
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            return services;
        }
    }
}
