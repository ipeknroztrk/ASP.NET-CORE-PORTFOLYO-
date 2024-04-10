using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;

namespace MyPortfolıoUdemy.ViewComponents
{
	public class _ExperienceComponentPartial:ViewComponent

	{
		MyPortfolıoContext context = new MyPortfolıoContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Experiences.ToList();
			return View(values);
		}
	}
}

