using Freelancer.Backend.Domain;
using Freelancer.Backend.Infrastructure.Interfaces;

namespace Freelancer.Backend.Infrastructure.Repositories
{
    public class RateRepository : Repository<Rating>
    {
        public RateRepository(ApplicationDatabaseContext context) : base(context)
        {
        }
    }
}
