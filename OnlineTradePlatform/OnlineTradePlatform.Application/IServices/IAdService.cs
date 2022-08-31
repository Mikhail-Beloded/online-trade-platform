using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Application.IServices
{
    public interface IAdService
    {
        Task AddAdAsync(Ad ad);

        Task<Ad> GetAdById(int id);

        Task<PagedList<Ad>> GetAdPageAsync (PageParameters pageParameters, string filter);
    }
}
