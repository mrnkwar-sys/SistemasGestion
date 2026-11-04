using Ejercicio01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio01.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewData["HoraActual"] = DateTime.Now.Hour;

            ViewBag.FechaActualLarga = DateTime.Now;

            if (DateTime.Now.Hour < 12)
            {
                ViewData["Saludo"] = "Buenos días";
            }
            else if (DateTime.Now.Hour < 18)
            {
                ViewData["Saludo"] = "Buenas tardes";
            }
            else
            {
                ViewData["Saludo"] = "Buenas noches";
            }

            return View();
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
