using Freelancer.Backend.Business;
using Freelancer.Backend.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Freelancer.Backend.CompositionRoot
{
    public static class CompositionRoot
    {
        public static IServiceCollection AddServices(this IServiceCollection services, string connectionString)
        {
            services.AddInfrastructure(connectionString);
            services.AddBusiness();
            return services;
        }
    }
}
