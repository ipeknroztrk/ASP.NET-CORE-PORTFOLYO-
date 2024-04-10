using System;
using Microsoft.AspNetCore.Mvc;
namespace MyPortfolıoUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

