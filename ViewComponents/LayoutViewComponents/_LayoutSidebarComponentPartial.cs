﻿using System;
using Microsoft.AspNetCore.Mvc;
namespace MyPortfolıoUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

