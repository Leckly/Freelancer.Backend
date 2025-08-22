using Freelancer.Backend.Domain;
using System.Linq.Expressions;

namespace Freelancer.Backend.Infrastructure.Interfaces;

public interface IJobRequestRepository : IRepository<JobRequest>
{
    Task DeleteAsync(int userId, int jobId);

    Task<IEnumerable<JobRequest>> GetAllWithJobsAsync(Expression<Func<JobRequest, bool>> predicate);
}
