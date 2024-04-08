using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel.Design;

namespace Freelancer.Backend.Business
{
    public static class DIRegistration
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            return services;
        }
    }
}
