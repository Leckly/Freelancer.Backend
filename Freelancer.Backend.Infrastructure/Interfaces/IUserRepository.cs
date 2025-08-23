using Freelancer.Backend.Domain;
using System.Linq.Expressions;

namespace Freelancer.Backend.Infrastructure.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetByEmailWithRoleAsync(Expression<Func<User, bool>> filter);
        Task<IEnumerable<User>> GetAllWithIncludesAsync();
        Task<User> GetByFilterWithPhotoAsync(Expression<Func<User, bool>> filter);
        Task<IEnumerable<User>> GetAllWithRatingsAsync();
        Task<IEnumerable<User>> GetAllByFilterAsync(Expression<Func<User, bool>> filter);
        Task<User> GetByFilterWithPhotoAndJobsAsync(Expression<Func<User, bool>> filter);
    }
}
