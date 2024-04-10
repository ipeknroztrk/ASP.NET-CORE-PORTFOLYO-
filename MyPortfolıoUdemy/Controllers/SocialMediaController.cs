using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPortfolıoUdemy.Controllers
{
    public class SocialMediaController : Controller
    {
        MyPortfolıoContext context = new MyPortfolıoContext();

        // GET: /<controller>/
        public IActionResult SocialMediaList()
        {
            var values = context.socialMedias.ToList();
            return View(values);
        }
    }
}

