using Freelancer.Backend.Domain;
using Freelancer.Backend.Infrastructure.Interfaces;

namespace Freelancer.Backend.Infrastructure.Repositories;

public class JobRequestRepository : Repository<JobRequest>, IJobRequestRepository
{
    public JobRequestRepository(ApplicationDatabaseContext context) : base(context)
    {
    }
}
