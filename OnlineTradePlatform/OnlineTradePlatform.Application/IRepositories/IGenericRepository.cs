using OnlineTradePlatform.Core.Entities;
using OnlineTradePlatform.Application.Paging;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Application.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken);

        Task AddAsync(TEntity entity, CancellationToken cancellationToken);
                
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken);
        
        Task<TEntity?> GetOneAsync(int id, CancellationToken cancellationToken);

        Task<PagedList<TEntity>> GetPageAsync (PageParameters parameters, CancellationToken cancellationToken);

        Task<PagedList<TEntity>> GetPageAsync(PageParameters parameters, Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
    }
}
