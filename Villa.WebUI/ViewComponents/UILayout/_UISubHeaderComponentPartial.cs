using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.SubHeaderDto;

namespace Villa.WebUI.ViewComponents.UILayout
{
	public class _UISubHeaderComponentPartial : ViewComponent
	{
		private readonly ISubHeaderService _subHeaderService;
		private readonly IMapper _mapper;
		public _UISubHeaderComponentPartial(ISubHeaderService subHeaderService, IMapper mapper)
		{
			_subHeaderService = subHeaderService;
			_mapper = mapper;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _subHeaderService.TGetListAsync();
			var subHeaderList = _mapper.Map<List<ResultSubHeaderDto>>(values);
			return View(subHeaderList);
		}
	}
}
