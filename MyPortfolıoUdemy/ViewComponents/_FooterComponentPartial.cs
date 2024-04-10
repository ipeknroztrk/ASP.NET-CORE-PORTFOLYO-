using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;
namespace MyPortfolıoUdemy.ViewComponents
	
{

	public class _FooterComponentPartial:ViewComponent
	{
		MyPortfolıoContext context = new MyPortfolıoContext();
		public IViewComponentResult Invoke()
		{
			var values = context.socialMedias.ToList();
			return View(values);
		}
	}
}

