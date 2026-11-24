using System.Diagnostics;
using Domain.Entities;
using Domain.Interfaces.UseCases;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using UI.Models.ViewModels;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUseCaseReservar _useCaseReservar;

        //Inyectamos IUseCaseReservar en el constructor del controlador
        public HomeController(IUseCaseReservar useCaseReservar)
        {
            _useCaseReservar = useCaseReservar;
        }

        public IActionResult Index()
        {
            //Fecha actual en formato largo
            ViewBag.FechaActual = DateTime.Now.ToLongDateString();

            //Guardamos las reservas y las habitaciones
            var reservas = _useCaseReservar.GetReservas();
            var habitaciones = _useCaseReservar.GetHabitaciones();

            //Creamos una lista de ReservaDetalleVM a partir de las reservas y habitaciones
            var listadoReservas = reservas.Select(r => new ReservaDetalleVM
            {
                Reserva = r,
                //Obtenemos el nombre de la habitación correspondiente a la reserva
                //Busca el primer elemento cuyo id coincida con el id de la habitación de la reserva, si no encuentra ninguno devuelve null
                //?.Nombre obtiene el nombre de la habitación si no es null
                //Si todo lo anterior es null, devuelve "Desconocido"
                NombreHabitacion = habitaciones.FirstOrDefault(h => h.Id == r.IdHabitacion)?.Nombre ?? "Desconocido"
            }).ToList();

            return View(listadoReservas);
        }

        public IActionResult DetallesReserva(int id)
        {
            var reserva = _useCaseReservar.GetReservaById(id);

            //Si no se encuentra la reserva, devolvemos un NotFound (404)
            if (reserva == null)
            {
                return NotFound();
            }

            var habitaciones = _useCaseReservar.GetHabitaciones();

            //Creamos un objeto ReservaDetalleVM con la reserva y el nombre de la habitación correspondiente
            var vm = new ReservaDetalleVM
            {
                Reserva = reserva,
                NombreHabitacion = habitaciones.FirstOrDefault(h => h.Id == reserva.IdHabitacion)?.Nombre ?? "Desconocido"
            };

            return View(vm);
        }

        public IActionResult EditarReserva (int id)
        {
            var reserva = _useCaseReservar.GetReservaById(id);
            if (reserva == null)
            {
                return NotFound();
            }

            var vm = new EditarReservaVM
            {
                Reserva = reserva,
                Habitaciones = _useCaseReservar.GetHabitaciones()
            };

            return View(vm);
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
