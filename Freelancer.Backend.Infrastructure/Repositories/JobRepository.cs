using Freelancer.Backend.Domain;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Freelancer.Backend.Infrastructure.Repositories
{
    public class JobRepository : Repository<Job>, IJobRepository
    {
        public JobRepository(ApplicationDatabaseContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Job>> GetAllWithIncludesAsync()
        {
            //return await _dbSet.Include(x => x.User).Include(x => x.JobTags).Include(x => x.JobPhotos).ToListAsync();
            return null;
        }

        public async Task<Job> GetByFilterWithPhotosAsync(Expression<Func<Job, bool>> filter)
        {
            return await _dbSet.Include(x => x.JobPhotos).FirstOrDefaultAsync(filter);
        }
    }
}
