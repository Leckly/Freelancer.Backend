using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Freelancer.Backend.Infrastructure.Interfaces
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly ApplicationDatabaseContext _context;

        protected Repository(ApplicationDatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entityToDelete = await _dbSet.FindAsync(id);

            _dbSet.Remove(entityToDelete);

            await _context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public virtual async Task<T> GetByFilterAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbSet.FirstOrDefaultAsync(filter);
        }

        public virtual async Task UpdateAsync(int id, T entity)
        {
            var entityToUpdate = await _dbSet.FindAsync(id);

            _context.Entry(entityToUpdate).CurrentValues.SetValues(entity);

            await _context.SaveChangesAsync();
        }
    }
}
