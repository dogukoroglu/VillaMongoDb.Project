using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.BannerDto;

namespace Villa.WebUI.ViewComponents.Default
{
    public class _DefaultBannerComponentPartial : ViewComponent
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;
        public _DefaultBannerComponentPartial(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _bannerService.TGetListAsync();
            var bannerList = _mapper.Map<List<ResultBannerDto>>(values);
            return View(bannerList);
        }
    }
}
