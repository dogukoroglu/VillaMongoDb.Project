using Microsoft.AspNetCore.Mvc;
namespace Villa.WebUI.ViewComponents.AdminLayout
{
	public class _AdminFooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
