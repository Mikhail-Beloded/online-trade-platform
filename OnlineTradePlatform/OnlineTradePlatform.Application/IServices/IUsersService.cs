using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Core.Entities;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Application.IServices
{
    public interface IUsersService
    {
        Task AddUser(User user, CancellationToken cancellationToken);

        Task<UserDTO> GetUserByIdAsync(int id, CancellationToken cancellationToken);

        Task<PagedList<UserDTO>> GetUsersPageAsync(PageParameters pageParameters, CancellationToken cancellationToken);

        Task<PagedList<UserDTO>> GetUsersPageAsync(PageParameters pageParameters, Expression<Func<User, bool>> predicate, CancellationToken cancellationToken);
    }
}
