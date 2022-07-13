using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using YoutCubeEntitiesMicroservice.Context;
using YoutCubeEntitiesMicroservice.Interfaces;

namespace YoutCubeEntitiesMicroservice.Repositories
{

    public class CommonRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly CommonContext context;
        private DbSet<T> entities;

        public CommonRepository(CommonContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }

        public virtual async Task AddAsync(T entity)
        {
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            var entity = await context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            if (entity == null)
                throw new ArgumentNullException("Can't Find Entity in Database");
            EntityEntry entityEntry = context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;

            await context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync() => await context.Set<T>().ToListAsync();
        public virtual async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return await query.ToListAsync();

        }

        public virtual async Task<T> GetByIdAsync(Guid id)
        {
            var result = await context.Set<T>().AsQueryable<T>().FirstOrDefaultAsync(n => n.Id == id);
            if (result == null)
                throw new ArgumentNullException("Can't Find Entity in Database");
            return result;
        }

        public virtual async Task<T> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = context.Set<T>();
            query = includeProperties.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            var result = await query.FirstOrDefaultAsync(n => n.Id == id);
            if (result == null)
                throw new ArgumentNullException("Can't Find Entity in Database");
            return result;
        }

        public virtual async Task UpdateAsync(T entity)
        { // check again
            EntityEntry entityEntry = context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;

            await context.SaveChangesAsync();
        }
    }
}