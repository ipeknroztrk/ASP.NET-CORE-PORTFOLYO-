using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;

namespace MyPortfolıoUdemy.ViewComponents
{
	public class _FeatureComponentPartial:ViewComponent
	{

		MyPortfolıoContext portfolıoContext = new MyPortfolıoContext();//1.yöntem

		public IViewComponentResult Invoke()
		{
			var values = portfolıoContext.Features.ToList();


			return View(values);
		}
		
		
	}
}

