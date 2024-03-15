using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.FeatureDto;

namespace Villa.WebUI.ViewComponents.Default
{
    public class _DefaultFeaturedComponentPartial : ViewComponent
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;
        public _DefaultFeaturedComponentPartial(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _featureService.TGetListAsync();
            var featureList = _mapper.Map<List<ResultFeatureDto>>(values);
            return View(featureList);
        }
    }
}
