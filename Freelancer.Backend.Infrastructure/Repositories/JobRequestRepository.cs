using Freelancer.Backend.Domain;
using Freelancer.Backend.Domain.Exceptions;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Freelancer.Backend.Infrastructure.Repositories;

public class JobRequestRepository : Repository<JobRequest>, IJobRequestRepository
{
    public JobRequestRepository(ApplicationDatabaseContext context) : base(context)
    {
    }

    public async Task DeleteAsync(int userId, int jobId)
    {
        var jobRequest = await _dbSet.Where(x => x.User.Id == userId && x.Job.Id == jobId).FirstOrDefaultAsync();

        if (jobRequest is null)
        {
            throw new EntityNotFoundApiException();
        }

        _dbSet.Remove(jobRequest);

        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<JobRequest>> GetAllWithJobsAsync(Expression<Func<JobRequest, bool>> predicate)
    {
        return await _dbSet.Where(predicate).Include(x => x.Job).ToListAsync();
    }
}
