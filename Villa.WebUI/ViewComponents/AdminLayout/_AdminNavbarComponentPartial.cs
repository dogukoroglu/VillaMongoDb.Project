using Microsoft.AspNetCore.Mvc;
namespace Villa.WebUI.ViewComponents.AdminLayout
{
	public class _AdminNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
