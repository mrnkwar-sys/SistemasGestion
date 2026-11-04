using Microsoft.AspNetCore.Mvc;
using RetoSinIA01.Models;
using System.Diagnostics;

namespace RetoSinIA01.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var horaActual = DateTime.Now;
            var fechaActual = horaActual.Date;

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
