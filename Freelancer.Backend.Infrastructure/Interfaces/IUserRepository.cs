using Freelancer.Backend.Domain;

namespace Freelancer.Backend.Infrastructure.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailWithRoleAsync(string email);
    }
}
