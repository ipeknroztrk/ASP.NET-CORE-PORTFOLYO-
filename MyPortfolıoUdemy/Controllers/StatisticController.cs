using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPortfolıoUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolıoContext context = new MyPortfolıoContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v4 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v5 = context.ToDoLists.Count(x => !x.Status == false);
            ViewBag.v6 = context.ToDoLists.Count(x => !x.Status == true);
            ViewBag.v7 = context.socialMedias.Count();
            ViewBag.v8 = context.Experiences.Count();
            ViewBag.v9 = context.Portfolıos.Count();
            ViewBag.v10 = context.Testimonials.Count();
        

            return View();
        }
    }
}

