using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Core.Entities;

namespace OnlineTradePlatform.Application.IServices
{
    public interface IUsersService
    {
        Task AddUser(User user, CancellationToken cancellationToken);

        Task<UserDTO> GetUserByIdAsync(int id, CancellationToken cancellationToken);

        Task<PagedList<UserDTO>> GetUsersPageAsync(PageParameters pageParameters, string filter, CancellationToken cancellationToken);
    }
}
