using Freelancer.Backend.Domain;
using Freelancer.Backend.Infrastructure.Interfaces;

namespace Freelancer.Backend.Infrastructure.Repositories
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(ApplicationDatabaseContext context) : base(context)
        {
        }
    }
}
