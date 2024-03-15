using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.CounterDto;

namespace Villa.WebUI.ViewComponents.Default
{
	public class _DefaultCounterComponentPartial : ViewComponent
	{
		private readonly ICounterService _counterService;
		private readonly IMapper _mapper;
		public _DefaultCounterComponentPartial(ICounterService counterService, IMapper mapper)
		{
			_counterService = counterService;
			_mapper = mapper;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _counterService.TGetListAsync();
			var counterList = _mapper.Map<List<ResultCounterDto>>(values);
			return View(counterList);
		}
	}
}
