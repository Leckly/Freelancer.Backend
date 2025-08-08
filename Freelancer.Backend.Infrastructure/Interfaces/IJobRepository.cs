using Freelancer.Backend.Domain;
using System.Linq.Expressions;

namespace Freelancer.Backend.Infrastructure.Interfaces
{
    public interface IJobRepository : IRepository<Job>
    {
        Task<IEnumerable<Job>> GetAllWithIncludesAsync();
        Task<Job> GetByFilterWithPhotosAsync(Expression<Func<Job, bool>> filter);
        Task<IEnumerable<Job>> GetAllWithPhotosAsync();
    }
}
