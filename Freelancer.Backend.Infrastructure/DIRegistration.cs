using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Freelancer.Backend.Infrastructure.Interfaces;
using Freelancer.Backend.Domain;
using Freelancer.Backend.Infrastructure.Repositories;

namespace Freelancer.Backend.Infrastructure
{
    public static class DIRegistration
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDatabaseContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IRepository<Role>, RoleRepository>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IPhotoContentRepository, PhotoContentRepository>();
            services.AddTransient<IDbInitializer, DbInitializer>();
            return services;
        }
    }
}
