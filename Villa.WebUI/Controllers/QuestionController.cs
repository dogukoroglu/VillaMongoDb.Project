using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Business.Abstract;
using Villa.Business.Validators;
using Villa.Dto.Dtos.QuestDto;
using Villa.Entity.Entities;

namespace Villa.WebUI.Controllers
{
	public class QuestionController : Controller
	{
		private readonly IQuestService _questService;
		private readonly IMapper _mapper;
		public QuestionController(IQuestService questService, IMapper mapper)
		{
			_questService = questService;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _questService.TGetListAsync();
			var QuestList = _mapper.Map<List<ResultQuestDto>>(values);
			return View(QuestList);
		}

		public async Task<IActionResult> DeleteQuestion(ObjectId id)
		{
			await _questService.TDeleteAsync(id);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult CreateQuestion()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateQuestion(CreateQuestDto createQuestDto)
		{
			ModelState.Clear(); // ingilizce hata mesajlarının önüne geçer
			var newQuest = _mapper.Map<Quest>(createQuestDto);
			var validator = new QuestionValidator();
			var result = validator.Validate(newQuest);
			if (!result.IsValid)
			{
				result.Errors.ForEach(x =>
				{
					ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
				});
				return View();
			}
			await _questService.TCreateAsync(newQuest);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public async Task<IActionResult> UpdateQuestion(ObjectId id)
		{
			var value = await _questService.TGetByIdAsync(id);
			var updataQuest = _mapper.Map<UpdateQuestDto>(value);
			return View(updataQuest);
		}

		[HttpPost]
		public async Task<IActionResult> UpdateQuestion(UpdateQuestDto updateQuestDto)
		{
			ModelState.Clear();
			var Quest = _mapper.Map<Quest>(updateQuestDto);
			var validator = new QuestionValidator();
			var result = validator.Validate(Quest);
			if (!result.IsValid)
			{
				result.Errors.ForEach(x =>
				{
					ModelState.AddModelError(x.PropertyName, x.ErrorMessage);
				});
				return View();
			}
			await _questService.TUpdateAsync(Quest);
			return RedirectToAction("Index");
		}
	}
}
