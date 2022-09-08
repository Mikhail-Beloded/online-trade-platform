using OnlineTradePlatform.Application.Mapping;
using OnlineTradePlatform.Application.IRepositories;
using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Application.IServices;
using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Core.Entities;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Infrastructure.Services
{
    public class UsersService : IUsersService
    {
        private readonly Mapper _mapper;

        private readonly IGenericRepository<User> _genericRepository;

        public UsersService(IGenericRepository<User> genericRepository)
        {
            this._genericRepository = genericRepository;
        }

        public async Task AddUser(UserDto user, CancellationToken cancellationToken)
        {
            var entity = this._mapper.MapUserFromDto(user);
            await this._genericRepository.AddAsync(entity, cancellationToken);
        }

        public async Task DeleteUserAsync(int id, CancellationToken cancellationToken)
        {
            var entity = await this._genericRepository.GetOneAsync(id, cancellationToken);
            await this._genericRepository.DeleteAsync(entity, cancellationToken);
        }

        public async Task<UserDto> GetUserByIdAsync(int id, CancellationToken cancellationToken)
        {
            var entity = await this._genericRepository.GetOneAsync(id, cancellationToken);
            UserDto dto = this._mapper.MapUserToDto(entity);
            return dto;
        }

        public async Task<PagedList<UserDto>> GetUsersPageAsync(PageParameters pageParameters, CancellationToken cancellationToken)
        {
            var entities = await this._genericRepository.GetPageAsync(pageParameters, cancellationToken);
            var users = this._mapper.MapUserListToDto(entities);
            return users;
        }

        public async Task<PagedList<UserDto>> GetUsersPageAsync(PageParameters pageParameters, Expression<Func<User, bool>> predicate, CancellationToken cancellationToken)
        {
            var entities = await this._genericRepository.GetPageAsync(pageParameters, predicate, cancellationToken);
            var users = this._mapper.MapUserListToDto(entities);
            return users;
        }
    }
}
