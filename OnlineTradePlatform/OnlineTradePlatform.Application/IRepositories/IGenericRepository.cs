using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Application.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        Task SaveAsync(CancellationToken cancellationToken);
        
        Task AddAsync(TEntity entity, CancellationToken cancellationToken);
        
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken);
        
        Task DeleteAsync(CancellationToken cancellationToken);
        
        Task<TEntity> GetOneAsync(int id, CancellationToken cancellationToken);
        
        Task<TEntity> GetAllAsync(CancellationToken cancellationToken);
    }
}
