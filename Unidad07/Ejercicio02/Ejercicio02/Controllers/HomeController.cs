using Ejercicio02.Models;
using Ejercicio02.Models.Data.Repositories;
using Ejercicio02.Models.Entities;
using Ejercicio02.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ejercicio02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            clsPersona misDatos = new clsPersona(1, "Raquel", "Nkwar", 1);
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

            return View(misDatos);
        }

        public IActionResult listadoPersonas()
        {
            
            List<clsPersona> listaPersonas = RepositoryPersona.getListadoPersonas();

            return View(listaPersonas);
        }

        public IActionResult InfoPersona()
        {
            List<clsPersona> listaPersonas = RepositoryPersona.getListadoPersonas();
            return View(listaPersonas);
        }

        public IActionResult EditarPersona()
        {
            List<clsPersona> listaPersonas = RepositoryPersona.getListadoPersonas();
            clsPersona persona = listaPersonas[Random.Shared.Next(listaPersonas.Count)];
            List<clsDepartamento> departamentos = RepositoryDepartamento.getListadoDepartamentos();

            return View(new PersonasDept(persona, departamentos));
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
