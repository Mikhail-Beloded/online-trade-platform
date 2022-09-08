using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Core.Entities;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Application.IServices
{
    public interface IAdService
    {
        Task AddAdAsync(AdDto ad, CancellationToken cancellationToken);

        Task<AdDto> GetAdByIdAsync(int id, CancellationToken cancellationToken);

        Task<PagedList<AdDto>> GetAdPageAsync (PageParameters pageParameters, CancellationToken cancellationToken);

        Task<PagedList<AdDto>> GetAdPageAsync(PageParameters pageParameters, Expression<Func<Ad, bool>> predicate, CancellationToken cancellationToken);
    
        Task DeleteAdAsync(int id, CancellationToken cancellationToken);
    }
}
