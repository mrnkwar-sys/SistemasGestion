using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Reserva
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public int NumeroNoches { get; set; }
        public int IdHabitacion { get; set; }
        public string Estado { get; set; }

        public Reserva()
        {
        }

        public Reserva(int id, string nombreCliente, string apellidoCliente, int numeroNoches, int idHabitacion, string estado)
        {
            Id = id;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            NumeroNoches = numeroNoches;
            IdHabitacion = idHabitacion;
            Estado = estado;
        }
    }
}
