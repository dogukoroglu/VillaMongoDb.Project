using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.AdminLayout
{
	public class _AdminHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
