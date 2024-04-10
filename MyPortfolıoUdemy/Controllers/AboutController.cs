using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MyPortfolıoUdemy.DAL.Context;
using MyPortfolıoUdemy.DAL.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPortfolıoUdemy.Controllers
{
    public class AboutController : Controller
    {
        MyPortfolıoContext context = new MyPortfolıoContext();
        // GET: /<controller>/
        public IActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
        
        
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}

