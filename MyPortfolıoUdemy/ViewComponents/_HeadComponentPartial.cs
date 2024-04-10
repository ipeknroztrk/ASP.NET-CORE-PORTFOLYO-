using System;
using Microsoft.AspNetCore.Mvc;
namespace MyPortfolıoUdemy.ViewComponents
{
	public class _HeadComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()//asp.net de ki actionresult gibi 
		{
			return View();
		}
	}
}

