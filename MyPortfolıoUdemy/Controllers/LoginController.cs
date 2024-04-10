using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;
using MyPortfolıoUdemy.DAL.Entities;

using System.Security.Claims;

namespace MyPortfolioUdemy.Controllers
{

    public class LoginController : Controller
    {
        MyPortfolıoContext context = new MyPortfolıoContext();


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(Admin admin)
        {
            var values = context.admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);

            if (values != null)
            {
                var claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Name, admin.UserName)
        };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "ToDoList");
            }
            return View();
        }

        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }

    }
}