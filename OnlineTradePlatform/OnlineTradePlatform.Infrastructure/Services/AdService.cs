using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Core.Entities;
using OnlineTradePlatform.Application.IServices;
using OnlineTradePlatform.Application.Paging;
using OnlineTradePlatform.Application.IRepositories;
using AutoMapper;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Infrastructure.Services
{
    public class AdService : IAdService
    {
        private readonly IMapper _mapper;

        private readonly IGenericRepository<Ad> _adRepository;

        public async Task AddAdAsync(Ad ad, CancellationToken cancellationToken)
        {
            await this._adRepository.AddAsync(ad, cancellationToken);
        }

        public async Task<AdDTO> GetAdByIdAsync(int id, CancellationToken cancellationToken)
        {
            var entity = await this._adRepository.GetOneAsync(id, cancellationToken);  
            var ad = _mapper.Map<AdDTO>(entity);
            return ad;
        }

        public async Task<PagedList<AdDTO>> GetAdPageAsync(PageParameters pageParameters, CancellationToken cancellationToken)
        {
            var entities = await this._adRepository.GetPageAsync(pageParameters, cancellationToken);
            var ads = _mapper.Map<PagedList<AdDTO>>(entities);
            return ads;
        }

        public async Task<PagedList<AdDTO>> GetAdPageAsync(PageParameters pageParameters, Expression<Func<Ad, bool>> predicate, CancellationToken cancellationToken)
        {
            var entities = await this._adRepository.GetPageAsync(pageParameters, predicate, cancellationToken);
            var ads = _mapper.Map<PagedList<AdDTO>>(entities);
            return ads;
        }
    }
}
