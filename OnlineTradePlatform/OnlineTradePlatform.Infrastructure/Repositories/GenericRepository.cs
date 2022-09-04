using OnlineTradePlatform.Application.IRepositories;
using OnlineTradePlatform.Core.Entities;
using OnlineTradePlatform.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using OnlineTradePlatform.Application.Paging;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        private readonly EFContext _db;

        private readonly DbSet<TEntity> _table;

        public GenericRepository(EFContext db)
        {
            this._db = db;
            this._table = this._db.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await this._table.AddAsync(entity, cancellationToken);
            await this._db.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken)
        {
            this._table.Remove(entity);
            await this._db.SaveChangesAsync(cancellationToken);
        }

        public async Task<TEntity> GetOneAsync(int id, CancellationToken cancellationToken)
        {
            return await this._table.FirstOrDefaultAsync<TEntity>(entity => entity.Id == id, cancellationToken);
        }

        public async Task<PagedList<TEntity>> GetPageAsync(PageParameters parameters, CancellationToken cancellationToken)
        {
            var entities = await this._table
                                     .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                                     .Take(parameters.PageSize)
                                     .ToListAsync(cancellationToken);

            var count = await this._table.CountAsync(cancellationToken);

            return new PagedList<TEntity>(entities, parameters, count);
        }

        public async Task<PagedList<TEntity>> GetPageAsync(PageParameters parameters, Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken)
        {
            var entities = await this._table
                                     .Where(predicate)
                                     .Skip((parameters.PageNumber - 1) * parameters.PageSize)
                                     .Take(parameters.PageSize)
                                     .ToListAsync(cancellationToken);

            var count = await this._table.CountAsync(cancellationToken);

            return new PagedList<TEntity>(entities, parameters, count);
        }

        public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            this._table.Update(entity);
            await this._db.SaveChangesAsync(cancellationToken);
        }
    }
}
