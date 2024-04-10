using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;
namespace MyPortfolıoUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarComponentPartial:ViewComponent
	{
		MyPortfolıoContext context = new MyPortfolıoContext();
		public IViewComponentResult Invoke()
		{
			ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();//okunmamıs bildirim sayısı


			var values = context.ToDoLists.Where(x => x.Status == false).ToList();

			return View(values);
		}
	}
}

