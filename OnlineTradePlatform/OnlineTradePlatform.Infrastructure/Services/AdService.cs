using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Core.Entities;
using OnlineTradePlatform.Application.IServices;
using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Application.IRepositories;
using OnlineTradePlatform.Application.Mapping;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Infrastructure.Services
{
    public class AdService : IAdService
    {
        private readonly Mapper _mapper;

        private readonly IGenericRepository<Ad> _adRepository;

        public AdService(IGenericRepository<Ad> adRepository)
        {
            this._adRepository = adRepository;
        }

        public async Task AddAdAsync(AdDto ad, CancellationToken cancellationToken)
        {
            var entity = this._mapper.MapAdFromDto(ad);
            await this._adRepository.AddAsync(entity, cancellationToken);
        }

        public async Task DeleteAdAsync(int id, CancellationToken cancellationToken)
        {
            var ad = await this._adRepository.GetOneAsync(id, cancellationToken);
            await this._adRepository.DeleteAsync(ad, cancellationToken);
        }

        public async Task<AdDto> GetAdByIdAsync(int id, CancellationToken cancellationToken)
        {
            var entity = await this._adRepository.GetOneAsync(id, cancellationToken);
            AdDto dto = this._mapper.MapAdToDto(entity);
            return dto;
        }

        public async Task<PagedList<AdDto>> GetAdPageAsync(PageParameters pageParameters, CancellationToken cancellationToken)
        {
            var entities = await this._adRepository.GetPageAsync(pageParameters, cancellationToken);
            var ads = this._mapper.MapAdListToDto(entities);
            return ads;
        }

        public async Task<PagedList<AdDto>> GetAdPageAsync(PageParameters pageParameters, Expression<Func<Ad, bool>> predicate, CancellationToken cancellationToken)
        {
            var entities = await this._adRepository.GetPageAsync(pageParameters, predicate, cancellationToken);
            var ads = this._mapper.MapAdListToDto(entities);
            return ads;
        }
    }
}
