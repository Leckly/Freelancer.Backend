﻿using Freelancer.Backend.Domain;
using Freelancer.Backend.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Freelancer.Backend.Infrastructure.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDatabaseContext context) : base(context)
        {
        }

        public async Task<User> GetByEmailWithRoleAsync(Expression<Func<User, bool>> filter)
        {
            return await _dbSet.Include(x => x.Role).Include(x => x.Photo).Include(x => x.UserTags).FirstOrDefaultAsync(filter);
        }
    }
}
