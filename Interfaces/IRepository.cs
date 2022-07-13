using System.Linq.Expressions;
using YoutCubeEntitiesMicroservice.Interfaces;

namespace YoutCubeEntitiesMicroservice.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        Task AddAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(Guid id, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task UpdateAsync(T entity);
    }
}