using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Application.IServices
{
    public interface IAdService
    {
        Task AddAdAsync(Ad ad, CancellationToken cancellationToken);

        Task<AdDTO> GetAdByIdAsync(int id, CancellationToken cancellationToken);

        Task<PagedList<AdDTO>> GetAdPageAsync (PageParameters pageParameters, string filter, CancellationToken cancellationToken);
    }
}
