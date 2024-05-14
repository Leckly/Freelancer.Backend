using Freelancer.Backend.Domain;

namespace Freelancer.Backend.Infrastructure.Interfaces
{
    public interface IJobRepository : IRepository<Job>
    {
        Task<IEnumerable<Job>> GetAllWithIncludesAsync();
    }
}
