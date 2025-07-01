using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;
namespace MyPortfolıoUdemy.ViewComponents
{
	public class _PortfolıoComponentPartial:ViewComponent
	{
		MyPortfolıoContext contex = new MyPortfolıoContext();
		public IViewComponentResult Invoke()
		{
			var values = contex.Portfolıos.ToList();

           
            return View(values);
		}
		
	}
}

