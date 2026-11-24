using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Data.Repositories
{
    //Implementa IRepositoryReserva
    public class RepositoryReserva : IRepositoryReserva
    {
        //Listado completo de las habitaciones
        private readonly List<Habitacion> _habitaciones = new()
        {
            new Habitacion(1, "Individual"),
            new Habitacion(2, "Doble"),
            new Habitacion(3, "Suite"),
            new Habitacion(4, "Presidencial"),
            new Habitacion(5, "Familiar")
        };

        //Listado completo de las reservas
        private readonly List<Reserva> _reservas = new()
        {
            new Reserva(1, "Juan", "Pérez", 3, 1, "Confirmada"),
            new Reserva(2, "María", "Gómez", 2, 2, "Pendiente"),
            new Reserva(3, "Carlos", "López", 5, 3, "Cancelada"),
            new Reserva(4, "Ana", "Martínez", 1, 4, "Confirmada"),
            new Reserva(5, "Luis", "Rodríguez", 4, 5, "Pendiente")
        };

        // Devuelve el listado completo de las reservas
        public List<Reserva> GetReservas()
        {
            return _reservas;
        }

        // Devuelve una reserva por el Id introducido
        public Reserva? GetReservaById(int id)
        {
            return _reservas.Find(r => r.Id == id);
        }

        // Devuelve el listado completo de las habitaciones
        public List<Habitacion> GetHabitaciones()
        {
            return _habitaciones;
        }
    }
}
