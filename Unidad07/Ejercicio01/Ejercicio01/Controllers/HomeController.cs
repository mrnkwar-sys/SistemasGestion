using Ejercicio01.Models;
using Ejercicio01.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio01.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            clsPersona misDatos = new clsPersona(1, "Raquel", "Nkwar");
            ViewBag.Persona = misDatos;

            int horaActual = DateTime.Now.Hour;

            ViewBag.FechaActualLarga = DateTime.Now;

            if (horaActual < 12)
            {
                ViewData["Saludo"] = "Buenos días";
            }
            else if (horaActual < 18)
            {
                ViewData["Saludo"] = "Buenas tardes";
            }
            else
            {
                ViewData["Saludo"] = "Buenas noches";
            }

            ViewBag.FechaActualLarga = DateTime.Now.ToLongDateString();

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
