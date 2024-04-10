using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyPortfolıoUdemy.DAL.Context;
using MyPortfolıoUdemy.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyPortfolıoUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolıoContext context = new MyPortfolıoContext()
;        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDoList()
        {

           
            return View();


        }
        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            if (ModelState.IsValid) // Model doğrulaması geçerli mi diye kontrol edin
            {
                toDoList.Date = DateTime.UtcNow; // Şuanki zamanı alın
                toDoList.Status = false; // Başlangıçta durumu false olarak ayarlayın

                context.ToDoLists.Add(toDoList); // ToDoList'i veritabanına ekleyin
                context.SaveChanges(); // Değişiklikleri kaydedin
                return RedirectToAction("Index"); // Index sayfasına yönlendirin
            }
            // Eğer model doğrulaması geçerli değilse, formu tekrar gösterin
            return View(toDoList);
        }


        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.ToDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            toDoList.Date = DateTime.UtcNow;
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeToDoListStatusToTrue(int id)
        {

            var values = context.ToDoLists.Find(id);
            values.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");

        }

       
        public IActionResult ChangeToDoListStatusToFalse(int id)
        {
            var values = context.ToDoLists.Find(id);
            values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}

