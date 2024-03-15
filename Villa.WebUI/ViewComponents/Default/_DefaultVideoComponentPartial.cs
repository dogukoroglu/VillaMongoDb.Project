using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.VideoDto;

namespace Villa.WebUI.ViewComponents.Default
{
	public class _DefaultVideoComponentPartial : ViewComponent
	{
		private readonly IVideoService _videoService;
		private readonly IMapper _mapper;
		public _DefaultVideoComponentPartial(IVideoService videoService, IMapper mapper)
		{
			_videoService = videoService;
			_mapper = mapper;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _videoService.TGetListAsync();
			var videoList = _mapper.Map<List<ResultVideoDto>>(values);
			return View(videoList);
		}
	}
}
