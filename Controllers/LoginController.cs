using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyPortfolıoUdemy.DAL.Context;
using MyPortfolıoUdemy.DAL.Entities;
using System.Security.Claims;

namespace MyPortfolioUdemy.Controllers
{
    [AllowAnonymous]
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
            var values = context.admins.FirstOrDefault(x =>
                x.UserName.Trim().ToLower() == admin.UserName.Trim().ToLower() &&
                x.Password.Trim() == admin.Password.Trim());

            if (values != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, values.UserName)
                };

                var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Index", "ToDoList");
            }

            ViewBag.Error = "Kullanıcı adı veya şifre hatalı.";
            return View();
        }

        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Login");
        }
    }
}
