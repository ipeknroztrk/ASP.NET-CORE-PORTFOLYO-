using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;
namespace MyPortfolıoUdemy.ViewComponents
{
	public class _TestimonialComponentPartial:ViewComponent
	{
		MyPortfolıoContext contex = new MyPortfolıoContext();
		public IViewComponentResult Invoke()

		{
			var values = contex.Testimonials.ToList();
			return View(values);
		}
	}
}

