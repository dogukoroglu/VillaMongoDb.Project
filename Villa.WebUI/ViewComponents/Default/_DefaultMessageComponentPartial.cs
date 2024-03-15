using Microsoft.AspNetCore.Mvc;

namespace Villa.WebUI.ViewComponents.Default
{
	public class _DefaultMessageComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
