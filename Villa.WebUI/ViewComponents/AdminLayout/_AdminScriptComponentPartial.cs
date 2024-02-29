using Microsoft.AspNetCore.Mvc;
namespace Villa.WebUI.ViewComponents.AdminLayout
{
	public class _AdminScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
