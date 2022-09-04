using AutoMapper;
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
        private readonly IMapper _mapper;

        private readonly IGenericRepository<User> _genericRepository;

        public async Task AddUser(User user, CancellationToken cancellationToken)
        {
            await this._genericRepository.AddAsync(user, cancellationToken);
        }

        public async Task<UserDTO> GetUserByIdAsync(int id, CancellationToken cancellationToken)
        {
            var entity = await this._genericRepository.GetOneAsync(id, cancellationToken);
            var resultDto = _mapper.Map<UserDTO>(entity);
            return resultDto;
        }

        public async Task<PagedList<UserDTO>> GetUsersPageAsync(PageParameters pageParameters, CancellationToken cancellationToken)
        {
            var entities = await this._genericRepository.GetPageAsync(pageParameters, cancellationToken);
            var users = _mapper.Map<PagedList<UserDTO>>(entities);
            return users;
        }

        public async Task<PagedList<UserDTO>> GetUsersPageAsync(PageParameters pageParameters, Expression<Func<User, bool>> predicate, CancellationToken cancellationToken)
        {
            var entities = await this._genericRepository.GetPageAsync(pageParameters, predicate, cancellationToken);
            var users = _mapper.Map<PagedList<UserDTO>>(entities);
            return users;
        }
    }
}
