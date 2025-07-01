using System;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;
namespace MyPortfolıoUdemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolıoContext portfolioContext = new MyPortfolıoContext();
        public IViewComponentResult Invoke()
        {

            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfolioContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View();
        }
    }
}

