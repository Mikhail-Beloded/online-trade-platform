using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Core.Entities;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Application.IServices
{
    public interface IUsersService
    {
        Task UpdateAsync(UserDto userDto, CancellationToken cancellationToken);

        Task AddUser(UserDto user, CancellationToken cancellationToken);

        Task<UserDto> GetUserByIdAsync(int id, CancellationToken cancellationToken);

        Task<PagedList<UserDto>> GetUsersPageAsync(PageParameters pageParameters, CancellationToken cancellationToken);

        Task<PagedList<UserDto>> GetUsersPageAsync(PageParameters pageParameters, Expression<Func<User, bool>> predicate, CancellationToken cancellationToken);

        Task DeleteUserAsync(UserDto userDto, CancellationToken cancellationToken);
    }
}
