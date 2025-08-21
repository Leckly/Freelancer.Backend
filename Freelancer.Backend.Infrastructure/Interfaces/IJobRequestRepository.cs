using Freelancer.Backend.Domain;

namespace Freelancer.Backend.Infrastructure.Interfaces;

public interface IJobRequestRepository : IRepository<JobRequest>
{
    Task DeleteAsync(int userId, int jobId);

    Task<IEnumerable<JobRequest>> GetAllWithJobsAsync(Func<JobRequest, bool> predicate);
}
