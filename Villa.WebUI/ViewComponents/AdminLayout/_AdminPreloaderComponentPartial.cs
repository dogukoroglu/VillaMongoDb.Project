using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.AdminLayout
{
	public class _AdminPreloaderComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
