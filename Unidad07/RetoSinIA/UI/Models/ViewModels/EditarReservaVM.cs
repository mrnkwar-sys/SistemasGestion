using Domain.Entities;

namespace UI.Models.ViewModels
{
    public class EditarReservaVM
    {
        public Reserva Reserva { get; set; }
        public List<Habitacion> Habitaciones { get; set; }
    }
}
