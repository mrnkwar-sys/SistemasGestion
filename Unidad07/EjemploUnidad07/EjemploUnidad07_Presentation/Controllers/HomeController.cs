using EjemploUnidad07_Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Domain;

namespace EjemploUnidad07_Presentation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            Persona persona = new Persona();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
