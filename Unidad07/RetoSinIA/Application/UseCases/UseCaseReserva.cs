using System;
using System.Collections.Generic;
using System.Text;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.UseCases;
using Domain.Entities;

namespace Application.UseCases
{
    //Implementa IUseCaseReservar e "inyecta" (instancia) IRepositoryReserva
    public class UseCaseReserva : IUseCaseReservar
    {
        private readonly IRepositoryReserva _repository;

        public UseCaseReserva(IRepositoryReserva repository)
        {
            _repository = repository;
        }

        public List<Reserva> GetReservas()
        {
            return _repository.GetReservas();
        }

        public Reserva? GetReservaById(int id)
        {
            return _repository.GetReservaById(id);
        }

        public List<Habitacion> GetHabitaciones()
        {
            return _repository.GetHabitaciones();
        }
    }
}
