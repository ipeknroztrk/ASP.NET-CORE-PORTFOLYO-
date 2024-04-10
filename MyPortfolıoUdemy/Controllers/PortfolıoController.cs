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
    public class PortfolıoController : Controller
    {
        MyPortfolıoContext context = new MyPortfolıoContext();
        // GET: /<controller>/
        public IActionResult PortfolıoList()
        {
            var values = context.Portfolıos.ToList();
            return View(values);
        }

        [HttpGet] //sayfa yüklenince çalışıcak
        public IActionResult CreatePortfolıo()
        {
            return View();
        }

        [HttpPost] //sayfa da bir butona tıklanınca 
        public IActionResult CreatePortfolıo(Portfolıo portfolıo)
        {
            context.Portfolıos.Add(portfolıo);
            context.SaveChanges();
            return RedirectToAction("PortfolıoList");
        }
        public IActionResult DeletePortfolıo(int id)
        {
            var value = context.Portfolıos.Find(id);
            context.Portfolıos.Remove(value);
            context.SaveChanges();
            return RedirectToAction("PortfolıoList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolıo(int id)
        {
            var value = context.Portfolıos.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdatePortfolıo(Portfolıo portfolıo)
        {
            context.Portfolıos.Update(portfolıo);
            context.SaveChanges();
            return RedirectToAction("PortfolıoList");
        }

    }
}

