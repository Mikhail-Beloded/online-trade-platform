using Microsoft.AspNetCore.Mvc;
using OnlineTradePlatform.Application.DTOs;
using OnlineTradePlatform.Application.IServices;
using OnlineTradePlatform.Core.Entities;
using OnlineTradePlatform.Application.Mapping;
using OnlineTradePlatform.Application.Paging;
using System.Linq.Expressions;

namespace OnlineTradePlatform.Web.Controllers
{
    public class AdController : Controller
    {
        private readonly IAdService _adService;

        private readonly Mapper _mapper = new();

        public AdController(IAdService adService)
        {
            this._adService = adService;
        }

        [HttpGet]
        async Task<IActionResult> UpdateAd(AdDto adDto, CancellationToken cancellationToken)
        {
            await this._adService.UpdateAsync(adDto, cancellationToken);
            return View();
        }

        [HttpPost]
        async Task<IActionResult> CreateAd(AdDto adDto, CancellationToken cancellationToken)
        {
            await this._adService.AddAdAsync(adDto, cancellationToken);
            return View();
        }

        [HttpPost]
        async Task<IActionResult> DeleteAd(AdDto adDto, CancellationToken cancellationToken)
        {
            await this._adService.DeleteAdAsync(adDto, cancellationToken);
            return View();
        }

        [HttpGet]
        async Task<IActionResult> GetAdsPage(PageParameters pageParameters, CancellationToken cancellationToken)
        {
            var result = await this._adService.GetAdPageAsync(pageParameters, cancellationToken);
            return View(result);
        }

        [HttpGet]
        async Task<IActionResult> GetAdsPage(PageParameters pageParameters, Expression<Func<Ad, bool>> predicate, CancellationToken cancellationToken)
        {
            var result = await this._adService.GetAdPageAsync(pageParameters, predicate, cancellationToken);
            return View(result);
        }

    }
}
