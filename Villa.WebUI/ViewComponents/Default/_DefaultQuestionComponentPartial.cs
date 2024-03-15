﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.QuestDto;

namespace Villa.WebUI.ViewComponents.Default
{
	public class _DefaultQuestionComponentPartial : ViewComponent
	{
		private readonly IQuestService _questService;
		private readonly IMapper _mapper;
		public _DefaultQuestionComponentPartial(IQuestService questService, IMapper mapper)
		{
			_questService = questService;
			_mapper = mapper;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _questService.TGetListAsync();
			var questList = _mapper.Map<List<ResultQuestDto>>(values);
			return View(questList);
		}
	}
}
