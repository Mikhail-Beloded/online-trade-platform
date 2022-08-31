using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Application.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        Task SaveAsync();
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync();
        Task<TEntity> GetOneAsync(int id);
        Task<TEntity> GetAllAsync();
    }
}
