using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Application.IServices
{
    public interface IUsersService
    {
        Task AddUser(User user);

        Task<User> GetUserById(int id);

        Task<PagedList<User>> GetUsersPageAsync(PageParameters pageParameters, string filter);
    }
}
