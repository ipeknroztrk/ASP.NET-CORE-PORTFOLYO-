using System;
using Microsoft.AspNetCore.Mvc;

using MyPortfolıoUdemy.DAL.Context;
namespace MyPortfolıoUdemy.ViewComponents
{
	public class _ContactComponentPartial:ViewComponent
	{
        MyPortfolıoContext contex = new MyPortfolıoContext();
        public IViewComponentResult Invoke()
        {
            var values = contex.Contacts.FirstOrDefault();


            return View(values);
        }
    }
}

