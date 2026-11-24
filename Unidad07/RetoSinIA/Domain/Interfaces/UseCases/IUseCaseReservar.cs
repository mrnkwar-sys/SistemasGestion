using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Domain.Interfaces.UseCases
{
    public interface IUseCaseReservar
    {
        //Listado completo de las reservas
        List<Reserva> GetReservas();

        //Obtener una reserva por su Id
        Reserva? GetReservaById(int id);

        //Listado completo de las habitaciones
        List<Habitacion> GetHabitaciones();
    }
}
