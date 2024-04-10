using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;
namespace MyPortfolıoUdemy.ViewComponents
{
	public class _SkillComponentPartial:ViewComponent
	{
		MyPortfolıoContext Context = new MyPortfolıoContext();

		public IViewComponentResult Invoke()
		{
			var values = Context.Skills.ToList();
			return View(values);
		}
	}
}

