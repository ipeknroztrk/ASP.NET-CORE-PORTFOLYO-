using System;
using Microsoft.AspNetCore.Mvc;
namespace MyPortfolıoUdemy.ViewComponents
{
	public class _NavbarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

