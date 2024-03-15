﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa.Business.Abstract;
using Villa.Dto.Dtos.ContactDto;

namespace Villa.WebUI.ViewComponents.Default
{
	public class _DefaultContactComponentPartial : ViewComponent
	{
		private readonly IContactService _contactService;
		private readonly IMapper _mapper;
		public _DefaultContactComponentPartial(IContactService contactService, IMapper mapper)
		{
			_contactService = contactService;
			_mapper = mapper;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _contactService.TGetListAsync();
			var contactList = _mapper.Map<List<ResultContactDto>>(values);
			return View(contactList);
		}
	}
}
