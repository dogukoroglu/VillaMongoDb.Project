using Microsoft.AspNetCore.Mvc;
namespace Villa.WebUI.ViewComponents.AdminLayout
{
	public class _AdminLogoComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
