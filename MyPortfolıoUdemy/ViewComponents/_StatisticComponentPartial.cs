using System;
using Microsoft.AspNetCore.Mvc;
namespace MyPortfolıoUdemy.ViewComponents
{
	public class _StatisticComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

