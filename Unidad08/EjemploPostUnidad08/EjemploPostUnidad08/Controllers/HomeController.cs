using EjemploPostUnidad08.Models;
using EjemploPostUnidad08.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EjemploPostUnidad08.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit ()
        {
            clsPersona myPerson = new clsPersona();
            myPerson.Name = "John";
            myPerson.Surname = "Doe";
            myPerson.Age = 30;
            return View(myPerson);
        }

        [HttpPost]
        public IActionResult Edit(clsPersona myPerson)
        {
            return View(myPerson);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
